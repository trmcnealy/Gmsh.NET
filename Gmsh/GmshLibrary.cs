
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;

#if x86
using size_t = System.UInt32;
#else
using size_t = System.UInt64;
#endif


namespace Gmsh
{
    public static class GmshLibrary
    {
        public static readonly Version ApiVersion;

        public static readonly string DLL_NAME;

        public static readonly nint   Handle;
        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static GmshLibrary()
        {
            ApiVersion = new Version(1, 0, 0, 0);
            
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                DLL_NAME = "libgmsh.so.1";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                DLL_NAME = "libgmsh-1.0.0.dylib";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                DLL_NAME = "gmsh.dll";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
            {
                DLL_NAME = "gmsh";
            }
            else
            {
                DLL_NAME = "gmsh";
            }

            Handle = DllMap.MapAndLoad(DLL_NAME);


            GetInstanceProcAddr = (delegate*<VkInstance, utf8string, nint>)(Handle + vkGetInstanceProcAddrOffset);

        }


    }
}
