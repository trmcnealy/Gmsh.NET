using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;

internal static class DllMap
{
    private static readonly Assembly executingAssembly;

    private static readonly string mapFileDir;
    private static readonly string mapFileName;
    private static readonly string mapFilePath;

    private static readonly string? osName;

    private static readonly XElement root;

    private static volatile bool _initialized;

    private static readonly Dictionary<string, Func<string, Version, string>> dllNameTemplates = new Dictionary<string, Func<string, Version, string>>()
    {
        {"osx", (name,     version)=>$"lib{name}.{version.Major}.dylib"},
        {"linux", (name,   version)=>$"lib{name}.so.{version.Major}"},
        {"windows", (name, version)=>$"{name}{version.Major}.dll"}
    };

    private static readonly Dictionary<string, string> dllFileExtensions = new Dictionary<string, string>()
    {
        {"osx", ".dylib"},
        {"linux", ".so"},
        {"windows", ".dll"}
    };

    private static readonly Dictionary<Architecture, string> architectureNames = new Dictionary<Architecture, string>()
    {
        {Architecture.X86, "x86"},
        {Architecture.X64, "x64"},
        {Architecture.Arm, "arm"},
        {Architecture.Arm64, "arm64"},
        {Architecture.Wasm, "wasm"},
    };

    static DllMap()
    {
        _initialized = false;
        
        executingAssembly = Assembly.GetExecutingAssembly();
        mapFileName       = Path.GetFileNameWithoutExtension(executingAssembly.Location) + ".dll.config";
        mapFileDir        = Path.GetDirectoryName(executingAssembly.Location) ?? throw new NullReferenceException("Assembly.GetExecutingAssembly() failed.");
        mapFilePath       = Path.Combine(mapFileDir, mapFileName);

        if(!File.Exists(mapFilePath))
        {
            throw new FileNotFoundException($"{mapFilePath} was not found.");
        }

        root = XElement.Load(mapFilePath);

        if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            osName = "linux";
        }
        else if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            osName = "osx";
        }
        else if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            osName = "windows";
        }
        else if(RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
        {
            osName = "freebsd";
        }
        else
        {
            osName = null;
        }

    }

    public static void Register()
    {
        if(!_initialized)
        {
            NativeLibrary.SetDllImportResolver(executingAssembly, MapAndLoad);

            //AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(MyResolveEventHandler);

            _initialized = true;
        }
    }

    internal static IntPtr MapAndLoad(string libraryName)
    {
        string? mappedName = MapLibraryName(libraryName);

        if(mappedName is null)
        {
            if(!Path.HasExtension(libraryName) && osName is not null)
            {
                mappedName = libraryName + dllFileExtensions[osName];
            }
            else
            {
                mappedName = libraryName;
            }
        }

        string dllPath;
        foreach(string path in NativeAssemblyResolver.Default.SearchPaths().ToArray())
        {
            dllPath = Path.Combine(path, mappedName);

            if(File.Exists(dllPath))
            {
                IntPtr libHandle = NativeLibrary.Load(dllPath);

                if(libHandle != IntPtr.Zero)
                {
                    return libHandle;
                }
            }
        }
        
        return IntPtr.Zero;
    }
    
    private static IntPtr MapAndLoad(string               libraryName,
                                     Assembly             assembly,
                                     DllImportSearchPath? dllImportSearchPath)
    {
        string? mappedName = MapLibraryName(libraryName);

        if(mappedName is null)
        {
            return NativeLibrary.Load(libraryName, assembly, dllImportSearchPath);
        }
        
        NativeLibrary.TryLoad(mappedName, assembly, DllImportSearchPath.System32, out IntPtr libHandle);

        return libHandle;

        //IntPtr libHandle = IntPtr.Zero;
        //if (libraryName == MyLibrary)
        //{
        //    // Try using the system library 'libmylibrary.so.5'
        //}
        //return libHandle;
    }

    internal static string? MapLibraryName(string originalLibName)
    {
        XElement? map = (root.Elements("dllmap").Where(el => (string)el.Attribute("dll")! == originalLibName &&
                                                             (string?)el.Attribute("os") == osName &&
                                                             (string?)el.Attribute("arch") == architectureNames[RuntimeInformation.OSArchitecture])).SingleOrDefault();

        return map?.Attribute("target")?.Value;
    }
}

public abstract class NativeAssemblyResolver
{
    public abstract IEnumerable<string> SearchPaths();
    
    public static NativeAssemblyResolver Default { get; } = new DefaultNativeAssemblyResolver();
}

public sealed class DefaultNativeAssemblyResolver : NativeAssemblyResolver
{
    public override IEnumerable<string> SearchPaths()
    {
        if(!string.IsNullOrEmpty(AppContext.BaseDirectory))
        {
            yield return AppContext.BaseDirectory;
        }

        if(!string.IsNullOrEmpty(AppDomain.CurrentDomain.BaseDirectory))
        {
            yield return AppDomain.CurrentDomain.BaseDirectory;
        }

        yield return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, GetRuntimeDirectory());

        yield return GetNugetPackagesRootDirectory();

        foreach(string path in Paths())
        {
            yield return path;
        }
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static string? GetOperatingSystem()
    {
        if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            return "linux";
        }
        if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            return "osx";
        }
        if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return "win";
        }
        if(RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
        {
            return "freebsd";
        }

        return null;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static string? GetOSArchitecture()
    {
        switch(RuntimeInformation.OSArchitecture)
        {
            case Architecture.X86:
            {
                return "x86";
            }
            case Architecture.X64:
            {
                return "x64";
            }
            case Architecture.Arm:
            {
                return "Arm";
            }
            case Architecture.Arm64:
            {
                return "Arm64";
            }
        }

        return null;
    }

    private static string GetRuntimeDirectory()
    {
        string rid = $"{GetOperatingSystem()}-{GetOSArchitecture()}";

        return Path.Combine("runtimes", rid, "native");
    }

    private static string GetNugetPackagesRootDirectory()
    {
        string userDirectory = GetUserDirectory();
        
        return Path.Combine(userDirectory, ".nuget", "packages");
    }

    private static string GetUserDirectory()
    {
        if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return Environment.GetEnvironmentVariable("USERPROFILE") ?? throw new NullReferenceException("USERPROFILE Environment Variable is missing");
        }

        if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            return Environment.GetEnvironmentVariable("HOME") ?? throw new NullReferenceException("HOME Environment Variable is missing");
        }

        if(RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
        {
            return Environment.GetEnvironmentVariable("HOME") ?? throw new NullReferenceException("HOME Environment Variable is missing");
        }

        return Environment.GetEnvironmentVariable("HOME") ?? throw new NullReferenceException("HOME Environment Variable is missing");
    }

    private static List<string> Paths()
    {
        string? pathEnvironmentVariable = Environment.GetEnvironmentVariable("PATH");

        if(!string.IsNullOrEmpty(pathEnvironmentVariable))
        {
            return pathEnvironmentVariable.Split(Path.PathSeparator).ToList();
        }

        return new();
    }
}