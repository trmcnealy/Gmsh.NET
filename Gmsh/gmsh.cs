using System;

namespace LibNative
{
    using System.Runtime.InteropServices;
    
    public static partial class libnative
    {
        /// <summary>
        /// All the functions in the Gmsh C API that return arrays allocate the
        /// necessary memory with gmshMalloc(). These arrays should be deallocated
        /// with gmshFree().
        /// </summary>

        public static unsafe delegate* <void*,void> gmshFree; gmshFree = (delegate* <void*,void>)NativeLibrary.GetExport(Handle, "gmshFree");
        

        public static unsafe delegate* <ulong,void*> gmshMalloc; gmshMalloc = (delegate* <ulong,void*>)NativeLibrary.GetExport(Handle, "gmshMalloc");
        
        /// <summary>
        /// Initialize the Gmsh API. This must be called before any call to the other
        /// functions in the API. If `argc' and `argv' (or just `argv' in Python or
        /// Julia) are provided, they will be handled in the same way as the command
        /// line arguments in the Gmsh app. If `readConfigFiles' is set, read system
        /// Gmsh configuration files (gmshrc and gmsh-options). If `run' is set, run in
        /// the same way as the Gmsh app, either interactively or in batch mode
        /// depending on the command line arguments. If `run' is not set, initializing
        /// the API sets the options "General.AbortOnError" to 2 and "General.Terminal"
        /// to 1. If compiled with OpenMP support, it also sets the number of threads
        /// to "General.NumThreads".
        /// </summary>

        public static unsafe delegate* <int,IntPtr*,int,int,int*,void> gmshInitialize; gmshInitialize = (delegate* <int,IntPtr*,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshInitialize");
        
        /// <summary>
        /// Return 1 if the Gmsh API is initialized, and 0 if not.
        /// </summary>

        public static unsafe delegate* <int*,int> gmshIsInitialized; gmshIsInitialized = (delegate* <int*,int>)NativeLibrary.GetExport(Handle, "gmshIsInitialized");
        
        /// <summary>
        /// Finalize the Gmsh API. This must be called when you are done using the Gmsh
        /// API.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshFinalize; gmshFinalize = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshFinalize");
        
        /// <summary>
        /// Open a file. Equivalent to the `File-&gt;Open' menu in the Gmsh app. Handling
        /// of the file depends on its extension and/or its contents: opening a file
        /// with model data will create a new model.
        /// </summary>

        public static unsafe delegate* <nint,int*,void> gmshOpen; gmshOpen = (delegate* <nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshOpen");
        
        /// <summary>
        /// Merge a file. Equivalent to the `File-&gt;Merge' menu in the Gmsh app.
        /// Handling of the file depends on its extension and/or its contents. Merging
        /// a file with model data will add the data to the current model.
        /// </summary>

        public static unsafe delegate* <nint,int*,void> gmshMerge; gmshMerge = (delegate* <nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshMerge");
        
        /// <summary>
        /// Write a file. The export format is determined by the file extension.
        /// </summary>

        public static unsafe delegate* <nint,int*,void> gmshWrite; gmshWrite = (delegate* <nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshWrite");
        
        /// <summary>
        /// Clear all loaded models and post-processing data, and add a new empty
        /// model.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshClear; gmshClear = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshClear");
        
        /// <summary>
        /// Set a numerical option to `value'. `name' is of the form "Category.Option"
        /// or "Category[num].Option". Available categories and options are listed in
        /// the Gmsh reference manual.
        /// </summary>

        public static unsafe delegate* <nint,double,int*,void> gmshOptionSetNumber; gmshOptionSetNumber = (delegate* <nint,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshOptionSetNumber");
        
        /// <summary>
        /// Get the `value' of a numerical option. `name' is of the form
        /// "Category.Option" or "Category[num].Option". Available categories and
        /// options are listed in the Gmsh reference manual.
        /// </summary>

        public static unsafe delegate* <nint,double*,int*,void> gmshOptionGetNumber; gmshOptionGetNumber = (delegate* <nint,double*,int*,void>)NativeLibrary.GetExport(Handle, "gmshOptionGetNumber");
        
        /// <summary>
        /// Set a string option to `value'. `name' is of the form "Category.Option" or
        /// "Category[num].Option". Available categories and options are listed in the
        /// Gmsh reference manual.
        /// </summary>

        public static unsafe delegate* <nint,nint,int*,void> gmshOptionSetString; gmshOptionSetString = (delegate* <nint,nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshOptionSetString");
        
        /// <summary>
        /// Get the `value' of a string option. `name' is of the form "Category.Option"
        /// or "Category[num].Option". Available categories and options are listed in
        /// the Gmsh reference manual.
        /// </summary>

        public static unsafe delegate* <nint,IntPtr*,int*,void> gmshOptionGetString; gmshOptionGetString = (delegate* <nint,IntPtr*,int*,void>)NativeLibrary.GetExport(Handle, "gmshOptionGetString");
        
        /// <summary>
        /// Set a color option to the RGBA value (`r', `g', `b', `a'), where where `r',
        /// `g', `b' and `a' should be integers between 0 and 255. `name' is of the
        /// form "Category.Color.Option" or "Category[num].Color.Option". Available
        /// categories and options are listed in the Gmsh reference manual. For
        /// conciseness "Color." can be ommitted in `name'.
        /// </summary>

        public static unsafe delegate* <nint,int,int,int,int,int*,void> gmshOptionSetColor; gmshOptionSetColor = (delegate* <nint,int,int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshOptionSetColor");
        
        /// <summary>
        /// Get the `r', `g', `b', `a' value of a color option. `name' is of the form
        /// "Category.Color.Option" or "Category[num].Color.Option". Available
        /// categories and options are listed in the Gmsh reference manual. For
        /// conciseness "Color." can be ommitted in `name'.
        /// </summary>

        public static unsafe delegate* <nint,int*,int*,int*,int*,int*,void> gmshOptionGetColor; gmshOptionGetColor = (delegate* <nint,int*,int*,int*,int*,int*,void>)NativeLibrary.GetExport(Handle, "gmshOptionGetColor");
        
        /// <summary>
        /// Add a new model, with name `name', and set it as the current model.
        /// </summary>

        public static unsafe delegate* <nint,int*,void> gmshModelAdd; gmshModelAdd = (delegate* <nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelAdd");
        
        /// <summary>
        /// Remove the current model.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshModelRemove; gmshModelRemove = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshModelRemove");
        
        /// <summary>
        /// List the names of all models.
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,int*,void> gmshModelList; gmshModelList = (delegate* <IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelList");
        
        /// <summary>
        /// Get the name of the current model.
        /// </summary>

        public static unsafe delegate* <IntPtr*,int*,void> gmshModelGetCurrent; gmshModelGetCurrent = (delegate* <IntPtr*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetCurrent");
        
        /// <summary>
        /// Set the current model to the model with name `name'. If several models have
        /// the same name, select the one that was added first.
        /// </summary>

        public static unsafe delegate* <nint,int*,void> gmshModelSetCurrent; gmshModelSetCurrent = (delegate* <nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelSetCurrent");
        
        /// <summary>
        /// Get the file name (if any) associated with the current model. A file name
        /// is associated when a model is read from a file on disk.
        /// </summary>

        public static unsafe delegate* <IntPtr*,int*,void> gmshModelGetFileName; gmshModelGetFileName = (delegate* <IntPtr*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetFileName");
        
        /// <summary>
        /// Set the file name associated with the current model.
        /// </summary>

        public static unsafe delegate* <nint,int*,void> gmshModelSetFileName; gmshModelSetFileName = (delegate* <nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelSetFileName");
        
        /// <summary>
        /// Get all the entities in the current model. If `dim' is &gt;= 0, return only
        /// the entities of the specified dimension (e.g. points if `dim' == 0). The
        /// entities are returned as a vector of (dim, tag) integer pairs.
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,int,int*,void> gmshModelGetEntities; gmshModelGetEntities = (delegate* <IntPtr*,ulong*,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetEntities");
        
        /// <summary>
        /// Set the name of the entity of dimension `dim' and tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,int,nint,int*,void> gmshModelSetEntityName; gmshModelSetEntityName = (delegate* <int,int,nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelSetEntityName");
        
        /// <summary>
        /// Get the name of the entity of dimension `dim' and tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,int,IntPtr*,int*,void> gmshModelGetEntityName; gmshModelGetEntityName = (delegate* <int,int,IntPtr*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetEntityName");
        
        /// <summary>
        /// Get all the physical groups in the current model. If `dim' is &gt;= 0, return
        /// only the entities of the specified dimension (e.g. physical points if `dim'
        /// == 0). The entities are returned as a vector of (dim, tag) integer pairs.
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,int,int*,void> gmshModelGetPhysicalGroups; gmshModelGetPhysicalGroups = (delegate* <IntPtr*,ulong*,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetPhysicalGroups");
        
        /// <summary>
        /// Get the tags of the model entities making up the physical group of
        /// dimension `dim' and tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,int,IntPtr*,ulong*,int*,void> gmshModelGetEntitiesForPhysicalGroup; gmshModelGetEntitiesForPhysicalGroup = (delegate* <int,int,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetEntitiesForPhysicalGroup");
        
        /// <summary>
        /// Get the tags of the physical groups (if any) to which the model entity of
        /// dimension `dim' and tag `tag' belongs.
        /// </summary>

        public static unsafe delegate* <int,int,IntPtr*,ulong*,int*,void> gmshModelGetPhysicalGroupsForEntity; gmshModelGetPhysicalGroupsForEntity = (delegate* <int,int,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetPhysicalGroupsForEntity");
        
        /// <summary>
        /// Add a physical group of dimension `dim', grouping the model entities with
        /// tags `tags'. Return the tag of the physical group, equal to `tag' if `tag'
        /// is positive, or a new tag if `tag' 
        /// &lt;
        /// 0. Set the name of the physical group
        /// if `name' is not empty.
        /// </summary>

        public static unsafe delegate* <int,int*,ulong,int,nint,int*,int> gmshModelAddPhysicalGroup; gmshModelAddPhysicalGroup = (delegate* <int,int*,ulong,int,nint,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelAddPhysicalGroup");
        
        /// <summary>
        /// Remove the physical groups `dimTags' from the current model. If `dimTags'
        /// is empty, remove all groups.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int*,void> gmshModelRemovePhysicalGroups; gmshModelRemovePhysicalGroups = (delegate* <int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelRemovePhysicalGroups");
        
        /// <summary>
        /// Set the name of the physical group of dimension `dim' and tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,int,nint,int*,void> gmshModelSetPhysicalName; gmshModelSetPhysicalName = (delegate* <int,int,nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelSetPhysicalName");
        
        /// <summary>
        /// Remove the physical name `name' from the current model.
        /// </summary>

        public static unsafe delegate* <nint,int*,void> gmshModelRemovePhysicalName; gmshModelRemovePhysicalName = (delegate* <nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelRemovePhysicalName");
        
        /// <summary>
        /// Get the name of the physical group of dimension `dim' and tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,int,IntPtr*,int*,void> gmshModelGetPhysicalName; gmshModelGetPhysicalName = (delegate* <int,int,IntPtr*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetPhysicalName");
        
        /// <summary>
        /// Set the tag of the entity of dimension `dim' and tag `tag' to the new value
        /// `newTag'.
        /// </summary>

        public static unsafe delegate* <int,int,int,int*,void> gmshModelSetTag; gmshModelSetTag = (delegate* <int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelSetTag");
        
        /// <summary>
        /// Get the boundary of the model entities `dimTags'. Return in `outDimTags'
        /// the boundary of the individual entities (if `combined' is false) or the
        /// boundary of the combined geometrical shape formed by all input entities (if
        /// `combined' is true). Return tags multiplied by the sign of the boundary
        /// entity if `oriented' is true. Apply the boundary operator recursively down
        /// to dimension 0 (i.e. to points) if `recursive' is true.
        /// </summary>

        public static unsafe delegate* <int*,ulong,IntPtr*,ulong*,int,int,int,int*,void> gmshModelGetBoundary; gmshModelGetBoundary = (delegate* <int*,ulong,IntPtr*,ulong*,int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetBoundary");
        
        /// <summary>
        /// Get the upward and downward adjacencies of the model entity of dimension
        /// `dim' and tag `tag'. The `upward' vector returns the adjacent entities of
        /// dimension `dim' + 1; the `downward' vector returns the adjacent entities of
        /// dimension `dim' - 1.
        /// </summary>

        public static unsafe delegate* <int,int,IntPtr*,ulong*,IntPtr*,ulong*,int*,void> gmshModelGetAdjacencies; gmshModelGetAdjacencies = (delegate* <int,int,IntPtr*,ulong*,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetAdjacencies");
        
        /// <summary>
        /// Get the model entities in the bounding box defined by the two points
        /// (`xmin', `ymin', `zmin') and (`xmax', `ymax', `zmax'). If `dim' is &gt;= 0,
        /// return only the entities of the specified dimension (e.g. points if `dim'
        /// == 0).
        /// </summary>

        public static unsafe delegate* <double,double,double,double,double,double,IntPtr*,ulong*,int,int*,void> gmshModelGetEntitiesInBoundingBox; gmshModelGetEntitiesInBoundingBox = (delegate* <double,double,double,double,double,double,IntPtr*,ulong*,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetEntitiesInBoundingBox");
        
        /// <summary>
        /// Get the bounding box (`xmin', `ymin', `zmin'), (`xmax', `ymax', `zmax') of
        /// the model entity of dimension `dim' and tag `tag'. If `dim' and `tag' are
        /// negative, get the bounding box of the whole model.
        /// </summary>

        public static unsafe delegate* <int,int,double*,double*,double*,double*,double*,double*,int*,void> gmshModelGetBoundingBox; gmshModelGetBoundingBox = (delegate* <int,int,double*,double*,double*,double*,double*,double*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetBoundingBox");
        
        /// <summary>
        /// Return the geometrical dimension of the current model.
        /// </summary>

        public static unsafe delegate* <int*,int> gmshModelGetDimension; gmshModelGetDimension = (delegate* <int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGetDimension");
        
        /// <summary>
        /// Add a discrete model entity (defined by a mesh) of dimension `dim' in the
        /// current model. Return the tag of the new discrete entity, equal to `tag' if
        /// `tag' is positive, or a new tag if `tag' 
        /// &lt;
        /// 0. `boundary' specifies the tags
        /// of the entities on the boundary of the discrete entity, if any. Specifying
        /// `boundary' allows Gmsh to construct the topology of the overall model.
        /// </summary>

        public static unsafe delegate* <int,int,int*,ulong,int*,int> gmshModelAddDiscreteEntity; gmshModelAddDiscreteEntity = (delegate* <int,int,int*,ulong,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelAddDiscreteEntity");
        
        /// <summary>
        /// Remove the entities `dimTags' of the current model, provided that they are
        /// not on the boundary of (or embedded in) higher-dimensional entities. If
        /// `recursive' is true, remove all the entities on their boundaries, down to
        /// dimension 0.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int*,void> gmshModelRemoveEntities; gmshModelRemoveEntities = (delegate* <int*,ulong,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelRemoveEntities");
        
        /// <summary>
        /// Remove the entity name `name' from the current model.
        /// </summary>

        public static unsafe delegate* <nint,int*,void> gmshModelRemoveEntityName; gmshModelRemoveEntityName = (delegate* <nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelRemoveEntityName");
        
        /// <summary>
        /// Get the type of the entity of dimension `dim' and tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,int,IntPtr*,int*,void> gmshModelGetType; gmshModelGetType = (delegate* <int,int,IntPtr*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetType");
        
        /// <summary>
        /// In a partitioned model, get the parent of the entity of dimension `dim' and
        /// tag `tag', i.e. from which the entity is a part of, if any. `parentDim' and
        /// `parentTag' are set to -1 if the entity has no parent.
        /// </summary>

        public static unsafe delegate* <int,int,int*,int*,int*,void> gmshModelGetParent; gmshModelGetParent = (delegate* <int,int,int*,int*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetParent");
        
        /// <summary>
        /// Return the number of partitions in the model.
        /// </summary>

        public static unsafe delegate* <int*,int> gmshModelGetNumberOfPartitions; gmshModelGetNumberOfPartitions = (delegate* <int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGetNumberOfPartitions");
        
        /// <summary>
        /// In a partitioned model, return the tags of the partition(s) to which the
        /// entity belongs.
        /// </summary>

        public static unsafe delegate* <int,int,IntPtr*,ulong*,int*,void> gmshModelGetPartitions; gmshModelGetPartitions = (delegate* <int,int,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetPartitions");
        
        /// <summary>
        /// Evaluate the parametrization of the entity of dimension `dim' and tag `tag'
        /// at the parametric coordinates `parametricCoord'. Only valid for `dim' equal
        /// to 0 (with empty `parametricCoord'), 1 (with `parametricCoord' containing
        /// parametric coordinates on the curve) or 2 (with `parametricCoord'
        /// containing pairs of u, v parametric coordinates on the surface,
        /// concatenated: [p1u, p1v, p2u, ...]). Return triplets of x, y, z coordinates
        /// in `coord', concatenated: [p1x, p1y, p1z, p2x, ...].
        /// </summary>

        public static unsafe delegate* <int,int,double*,ulong,IntPtr*,ulong*,int*,void> gmshModelGetValue; gmshModelGetValue = (delegate* <int,int,double*,ulong,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetValue");
        
        /// <summary>
        /// Evaluate the derivative of the parametrization of the entity of dimension
        /// `dim' and tag `tag' at the parametric coordinates `parametricCoord'. Only
        /// valid for `dim' equal to 1 (with `parametricCoord' containing parametric
        /// coordinates on the curve) or 2 (with `parametricCoord' containing pairs of
        /// u, v parametric coordinates on the surface, concatenated: [p1u, p1v, p2u,
        /// ...]). For `dim' equal to 1 return the x, y, z components of the derivative
        /// with respect to u [d1ux, d1uy, d1uz, d2ux, ...]; for `dim' equal to 2
        /// return the x, y, z components of the derivative with respect to u and v:
        /// [d1ux, d1uy, d1uz, d1vx, d1vy, d1vz, d2ux, ...].
        /// </summary>

        public static unsafe delegate* <int,int,double*,ulong,IntPtr*,ulong*,int*,void> gmshModelGetDerivative; gmshModelGetDerivative = (delegate* <int,int,double*,ulong,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetDerivative");
        
        /// <summary>
        /// Evaluate the second derivative of the parametrization of the entity of
        /// dimension `dim' and tag `tag' at the parametric coordinates
        /// `parametricCoord'. Only valid for `dim' equal to 1 (with `parametricCoord'
        /// containing parametric coordinates on the curve) or 2 (with
        /// `parametricCoord' containing pairs of u, v parametric coordinates on the
        /// surface, concatenated: [p1u, p1v, p2u, ...]). For `dim' equal to 1 return
        /// the x, y, z components of the second derivative with respect to u [d1uux,
        /// d1uuy, d1uuz, d2uux, ...]; for `dim' equal to 2 return the x, y, z
        /// components of the second derivative with respect to u and v, and the mixed
        /// derivative with respect to u and v: [d1uux, d1uuy, d1uuz, d1vvx, d1vvy,
        /// d1vvz, d1uvx, d1uvy, d1uvz, d2uux, ...].
        /// </summary>

        public static unsafe delegate* <int,int,double*,ulong,IntPtr*,ulong*,int*,void> gmshModelGetSecondDerivative; gmshModelGetSecondDerivative = (delegate* <int,int,double*,ulong,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetSecondDerivative");
        
        /// <summary>
        /// Evaluate the (maximum) curvature of the entity of dimension `dim' and tag
        /// `tag' at the parametric coordinates `parametricCoord'. Only valid for `dim'
        /// equal to 1 (with `parametricCoord' containing parametric coordinates on the
        /// curve) or 2 (with `parametricCoord' containing pairs of u, v parametric
        /// coordinates on the surface, concatenated: [p1u, p1v, p2u, ...]).
        /// </summary>

        public static unsafe delegate* <int,int,double*,ulong,IntPtr*,ulong*,int*,void> gmshModelGetCurvature; gmshModelGetCurvature = (delegate* <int,int,double*,ulong,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetCurvature");
        
        /// <summary>
        /// Evaluate the principal curvatures of the surface with tag `tag' at the
        /// parametric coordinates `parametricCoord', as well as their respective
        /// directions. `parametricCoord' are given by pair of u and v coordinates,
        /// concatenated: [p1u, p1v, p2u, ...].
        /// </summary>

        public static unsafe delegate* <int,double*,ulong,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int*,void> gmshModelGetPrincipalCurvatures; gmshModelGetPrincipalCurvatures = (delegate* <int,double*,ulong,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetPrincipalCurvatures");
        
        /// <summary>
        /// Get the normal to the surface with tag `tag' at the parametric coordinates
        /// `parametricCoord'. `parametricCoord' are given by pairs of u and v
        /// coordinates, concatenated: [p1u, p1v, p2u, ...]. `normals' are returned as
        /// triplets of x, y, z components, concatenated: [n1x, n1y, n1z, n2x, ...].
        /// </summary>

        public static unsafe delegate* <int,double*,ulong,IntPtr*,ulong*,int*,void> gmshModelGetNormal; gmshModelGetNormal = (delegate* <int,double*,ulong,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetNormal");
        
        /// <summary>
        /// Get the parametric coordinates `parametricCoord' for the points `coord' on
        /// the entity of dimension `dim' and tag `tag'. `coord' are given as triplets
        /// of x, y, z coordinates, concatenated: [p1x, p1y, p1z, p2x, ...].
        /// `parametricCoord' returns the parametric coordinates t on the curve (if
        /// `dim' = 1) or pairs of u and v coordinates concatenated on the surface (if
        /// `dim' = 2), i.e. [p1t, p2t, ...] or [p1u, p1v, p2u, ...].
        /// </summary>

        public static unsafe delegate* <int,int,double*,ulong,IntPtr*,ulong*,int*,void> gmshModelGetParametrization; gmshModelGetParametrization = (delegate* <int,int,double*,ulong,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetParametrization");
        
        /// <summary>
        /// Get the `min' and `max' bounds of the parametric coordinates for the entity
        /// of dimension `dim' and tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,int,IntPtr*,ulong*,IntPtr*,ulong*,int*,void> gmshModelGetParametrizationBounds; gmshModelGetParametrizationBounds = (delegate* <int,int,IntPtr*,ulong*,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetParametrizationBounds");
        
        /// <summary>
        /// Check if the coordinates (or the parametric coordinates if `parametric' is
        /// set) provided in `coord' correspond to points inside the entity of
        /// dimension `dim' and tag `tag', and return the number of points inside. This
        /// feature is only available for a subset of entities, depending on the
        /// underlying geometrical representation.
        /// </summary>

        public static unsafe delegate* <int,int,double*,ulong,int,int*,int> gmshModelIsInside; gmshModelIsInside = (delegate* <int,int,double*,ulong,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelIsInside");
        
        /// <summary>
        /// Get the points `closestCoord' on the entity of dimension `dim' and tag
        /// `tag' to the points `coord', by orthogonal projection. `coord' and
        /// `closestCoord' are given as triplets of x, y, z coordinates, concatenated:
        /// [p1x, p1y, p1z, p2x, ...]. `parametricCoord' returns the parametric
        /// coordinates t on the curve (if `dim' = 1) or pairs of u and v coordinates
        /// concatenated on the surface (if `dim' = 2), i.e. [p1t, p2t, ...] or [p1u,
        /// p1v, p2u, ...].
        /// </summary>

        public static unsafe delegate* <int,int,double*,ulong,IntPtr*,ulong*,IntPtr*,ulong*,int*,void> gmshModelGetClosestPoint; gmshModelGetClosestPoint = (delegate* <int,int,double*,ulong,IntPtr*,ulong*,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetClosestPoint");
        
        /// <summary>
        /// Reparametrize the boundary entity (point or curve, i.e. with `dim' == 0 or
        /// `dim' == 1) of tag `tag' on the surface `surfaceTag'. If `dim' == 1,
        /// reparametrize all the points corresponding to the parametric coordinates
        /// `parametricCoord'. Multiple matches in case of periodic surfaces can be
        /// selected with `which'. This feature is only available for a subset of
        /// entities, depending on the underlying geometrical representation.
        /// </summary>

        public static unsafe delegate* <int,int,double*,ulong,int,IntPtr*,ulong*,int,int*,void> gmshModelReparametrizeOnSurface; gmshModelReparametrizeOnSurface = (delegate* <int,int,double*,ulong,int,IntPtr*,ulong*,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelReparametrizeOnSurface");
        
        /// <summary>
        /// Set the visibility of the model entities `dimTags' to `value'. Apply the
        /// visibility setting recursively if `recursive' is true.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int,int*,void> gmshModelSetVisibility; gmshModelSetVisibility = (delegate* <int*,ulong,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelSetVisibility");
        
        /// <summary>
        /// Get the visibility of the model entity of dimension `dim' and tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,int,int*,int*,void> gmshModelGetVisibility; gmshModelGetVisibility = (delegate* <int,int,int*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetVisibility");
        
        /// <summary>
        /// Set the global visibility of the model per window to `value', where
        /// `windowIndex' identifies the window in the window list.
        /// </summary>

        public static unsafe delegate* <int,int,int*,void> gmshModelSetVisibilityPerWindow; gmshModelSetVisibilityPerWindow = (delegate* <int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelSetVisibilityPerWindow");
        
        /// <summary>
        /// Set the color of the model entities `dimTags' to the RGBA value (`r', `g',
        /// `b', `a'), where `r', `g', `b' and `a' should be integers between 0 and
        /// 255. Apply the color setting recursively if `recursive' is true.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int,int,int,int,int*,void> gmshModelSetColor; gmshModelSetColor = (delegate* <int*,ulong,int,int,int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelSetColor");
        
        /// <summary>
        /// Get the color of the model entity of dimension `dim' and tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,int,int*,int*,int*,int*,int*,void> gmshModelGetColor; gmshModelGetColor = (delegate* <int,int,int*,int*,int*,int*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGetColor");
        
        /// <summary>
        /// Set the `x', `y', `z' coordinates of a geometrical point.
        /// </summary>

        public static unsafe delegate* <int,double,double,double,int*,void> gmshModelSetCoordinates; gmshModelSetCoordinates = (delegate* <int,double,double,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelSetCoordinates");
        
        /// <summary>
        /// Generate a mesh of the current model, up to dimension `dim' (0, 1, 2 or 3).
        /// </summary>

        public static unsafe delegate* <int,int*,void> gmshModelMeshGenerate; gmshModelMeshGenerate = (delegate* <int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGenerate");
        
        /// <summary>
        /// Partition the mesh of the current model into `numPart' partitions.
        /// Optionally, `elementTags' and `partitions' can be provided to specify the
        /// partition of each element explicitly.
        /// </summary>

        public static unsafe delegate* <int,ulong*,ulong,int*,ulong,int*,void> gmshModelMeshPartition; gmshModelMeshPartition = (delegate* <int,ulong*,ulong,int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshPartition");
        
        /// <summary>
        /// Unpartition the mesh of the current model.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshModelMeshUnpartition; gmshModelMeshUnpartition = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshUnpartition");
        
        /// <summary>
        /// Optimize the mesh of the current model using `method' (empty for default
        /// tetrahedral mesh optimizer, "Netgen" for Netgen optimizer, "HighOrder" for
        /// direct high-order mesh optimizer, "HighOrderElastic" for high-order elastic
        /// smoother, "HighOrderFastCurving" for fast curving algorithm, "Laplace2D"
        /// for Laplace smoothing, "Relocate2D" and "Relocate3D" for node relocation,
        /// "QuadQuasiStructured" for quad mesh optimization, "UntangleMeshGeometry"
        /// for untangling). If `force' is set apply the optimization also to discrete
        /// entities. If `dimTags' is given, only apply the optimizer to the given
        /// entities.
        /// </summary>

        public static unsafe delegate* <nint,int,int,int*,ulong,int*,void> gmshModelMeshOptimize; gmshModelMeshOptimize = (delegate* <nint,int,int,int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshOptimize");
        
        /// <summary>
        /// Recombine the mesh of the current model.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshModelMeshRecombine; gmshModelMeshRecombine = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshRecombine");
        
        /// <summary>
        /// Refine the mesh of the current model by uniformly splitting the elements.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshModelMeshRefine; gmshModelMeshRefine = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshRefine");
        
        /// <summary>
        /// Set the order of the elements in the mesh of the current model to `order'.
        /// </summary>

        public static unsafe delegate* <int,int*,void> gmshModelMeshSetOrder; gmshModelMeshSetOrder = (delegate* <int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSetOrder");
        
        /// <summary>
        /// Get the last entities (if any) where a meshing error occurred. Currently
        /// only populated by the new 3D meshing algorithms.
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,int*,void> gmshModelMeshGetLastEntityError; gmshModelMeshGetLastEntityError = (delegate* <IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetLastEntityError");
        
        /// <summary>
        /// Get the last nodes (if any) where a meshing error occurred. Currently only
        /// populated by the new 3D meshing algorithms.
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,int*,void> gmshModelMeshGetLastNodeError; gmshModelMeshGetLastNodeError = (delegate* <IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetLastNodeError");
        
        /// <summary>
        /// Clear the mesh, i.e. delete all the nodes and elements, for the entities
        /// `dimTags'. If `dimTags' is empty, clear the whole mesh. Note that the mesh
        /// of an entity can only be cleared if this entity is not on the boundary of
        /// another entity with a non-empty mesh.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int*,void> gmshModelMeshClear; gmshModelMeshClear = (delegate* <int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshClear");
        
        /// <summary>
        /// Reverse the orientation of the elements in the entities `dimTags'. If
        /// `dimTags' is empty, reverse the orientation of the elements in the whole
        /// mesh.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int*,void> gmshModelMeshReverse; gmshModelMeshReverse = (delegate* <int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshReverse");
        
        /// <summary>
        /// Apply the affine transformation `affineTransform' (16 entries of a 4x4
        /// matrix, by row; only the 12 first can be provided for convenience) to the
        /// coordinates of the nodes classified on the entities `dimTags'. If `dimTags'
        /// is empty, transform all the nodes in the mesh.
        /// </summary>

        public static unsafe delegate* <double*,ulong,int*,ulong,int*,void> gmshModelMeshAffineTransform; gmshModelMeshAffineTransform = (delegate* <double*,ulong,int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshAffineTransform");
        
        /// <summary>
        /// Get the nodes classified on the entity of dimension `dim' and tag `tag'. If
        /// `tag' 
        /// &lt;
        /// 0, get the nodes for all entities of dimension `dim'. If `dim' and
        /// `tag' are negative, get all the nodes in the mesh. `nodeTags' contains the
        /// node tags (their unique, strictly positive identification numbers). `coord'
        /// is a vector of length 3 times the length of `nodeTags' that contains the x,
        /// y, z coordinates of the nodes, concatenated: [n1x, n1y, n1z, n2x, ...]. If
        /// `dim' &gt;= 0 and `returnParamtricCoord' is set, `parametricCoord' contains
        /// the parametric coordinates ([u1, u2, ...] or [u1, v1, u2, ...]) of the
        /// nodes, if available. The length of `parametricCoord' can be 0 or `dim'
        /// times the length of `nodeTags'. If `includeBoundary' is set, also return
        /// the nodes classified on the boundary of the entity (which will be
        /// reparametrized on the entity if `dim' &gt;= 0 in order to compute their
        /// parametric coordinates).
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int,int,int,int,int*,void> gmshModelMeshGetNodes; gmshModelMeshGetNodes = (delegate* <IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int,int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetNodes");
        
        /// <summary>
        /// Get the nodes classified on the entity of tag `tag', for all the elements
        /// of type `elementType'. The other arguments are treated as in `getNodes'.
        /// </summary>

        public static unsafe delegate* <int,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int,int,int*,void> gmshModelMeshGetNodesByElementType; gmshModelMeshGetNodesByElementType = (delegate* <int,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetNodesByElementType");
        
        /// <summary>
        /// Get the coordinates and the parametric coordinates (if any) of the node
        /// with tag `tag', as well as the dimension `dim' and tag `tag' of the entity
        /// on which the node is classified. This function relies on an internal cache
        /// (a vector in case of dense node numbering, a map otherwise); for large
        /// meshes accessing nodes in bulk is often preferable.
        /// </summary>

        public static unsafe delegate* <ulong,IntPtr*,ulong*,IntPtr*,ulong*,int*,int*,int*,void> gmshModelMeshGetNode; gmshModelMeshGetNode = (delegate* <ulong,IntPtr*,ulong*,IntPtr*,ulong*,int*,int*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetNode");
        
        /// <summary>
        /// Set the coordinates and the parametric coordinates (if any) of the node
        /// with tag `tag'. This function relies on an internal cache (a vector in case
        /// of dense node numbering, a map otherwise); for large meshes accessing nodes
        /// in bulk is often preferable.
        /// </summary>

        public static unsafe delegate* <ulong,double*,ulong,double*,ulong,int*,void> gmshModelMeshSetNode; gmshModelMeshSetNode = (delegate* <ulong,double*,ulong,double*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSetNode");
        
        /// <summary>
        /// Rebuild the node cache.
        /// </summary>

        public static unsafe delegate* <int,int*,void> gmshModelMeshRebuildNodeCache; gmshModelMeshRebuildNodeCache = (delegate* <int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshRebuildNodeCache");
        
        /// <summary>
        /// Rebuild the element cache.
        /// </summary>

        public static unsafe delegate* <int,int*,void> gmshModelMeshRebuildElementCache; gmshModelMeshRebuildElementCache = (delegate* <int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshRebuildElementCache");
        
        /// <summary>
        /// Get the nodes from all the elements belonging to the physical group of
        /// dimension `dim' and tag `tag'. `nodeTags' contains the node tags; `coord'
        /// is a vector of length 3 times the length of `nodeTags' that contains the x,
        /// y, z coordinates of the nodes, concatenated: [n1x, n1y, n1z, n2x, ...].
        /// </summary>

        public static unsafe delegate* <int,int,IntPtr*,ulong*,IntPtr*,ulong*,int*,void> gmshModelMeshGetNodesForPhysicalGroup; gmshModelMeshGetNodesForPhysicalGroup = (delegate* <int,int,IntPtr*,ulong*,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetNodesForPhysicalGroup");
        
        /// <summary>
        /// Get the maximum tag `maxTag' of a node in the mesh.
        /// </summary>

        public static unsafe delegate* <ulong*,int*,void> gmshModelMeshGetMaxNodeTag; gmshModelMeshGetMaxNodeTag = (delegate* <ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetMaxNodeTag");
        
        /// <summary>
        /// Add nodes classified on the model entity of dimension `dim' and tag `tag'.
        /// `nodeTags' contains the node tags (their unique, strictly positive
        /// identification numbers). `coord' is a vector of length 3 times the length
        /// of `nodeTags' that contains the x, y, z coordinates of the nodes,
        /// concatenated: [n1x, n1y, n1z, n2x, ...]. The optional `parametricCoord'
        /// vector contains the parametric coordinates of the nodes, if any. The length
        /// of `parametricCoord' can be 0 or `dim' times the length of `nodeTags'. If
        /// the `nodeTags' vector is empty, new tags are automatically assigned to the
        /// nodes.
        /// </summary>

        public static unsafe delegate* <int,int,ulong*,ulong,double*,ulong,double*,ulong,int*,void> gmshModelMeshAddNodes; gmshModelMeshAddNodes = (delegate* <int,int,ulong*,ulong,double*,ulong,double*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshAddNodes");
        
        /// <summary>
        /// Reclassify all nodes on their associated model entity, based on the
        /// elements. Can be used when importing nodes in bulk (e.g. by associating
        /// them all to a single volume), to reclassify them correctly on model
        /// surfaces, curves, etc. after the elements have been set.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshModelMeshReclassifyNodes; gmshModelMeshReclassifyNodes = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshReclassifyNodes");
        
        /// <summary>
        /// Relocate the nodes classified on the entity of dimension `dim' and tag
        /// `tag' using their parametric coordinates. If `tag' 
        /// &lt;
        /// 0, relocate the nodes
        /// for all entities of dimension `dim'. If `dim' and `tag' are negative,
        /// relocate all the nodes in the mesh.
        /// </summary>

        public static unsafe delegate* <int,int,int*,void> gmshModelMeshRelocateNodes; gmshModelMeshRelocateNodes = (delegate* <int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshRelocateNodes");
        
        /// <summary>
        /// Get the elements classified on the entity of dimension `dim' and tag `tag'.
        /// If `tag' 
        /// &lt;
        /// 0, get the elements for all entities of dimension `dim'. If
        /// `dim' and `tag' are negative, get all the elements in the mesh.
        /// `elementTypes' contains the MSH types of the elements (e.g. `2' for 3-node
        /// triangles: see `getElementProperties' to obtain the properties for a given
        /// element type). `elementTags' is a vector of the same length as
        /// `elementTypes'; each entry is a vector containing the tags (unique,
        /// strictly positive identifiers) of the elements of the corresponding type.
        /// `nodeTags' is also a vector of the same length as `elementTypes'; each
        /// entry is a vector of length equal to the number of elements of the given
        /// type times the number N of nodes for this type of element, that contains
        /// the node tags of all the elements of the given type, concatenated: [e1n1,
        /// e1n2, ..., e1nN, e2n1, ...].
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,int,int,int*,void> gmshModelMeshGetElements; gmshModelMeshGetElements = (delegate* <IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetElements");
        
        /// <summary>
        /// Get the type and node tags of the element with tag `tag', as well as the
        /// dimension `dim' and tag `tag' of the entity on which the element is
        /// classified. This function relies on an internal cache (a vector in case of
        /// dense element numbering, a map otherwise); for large meshes accessing
        /// elements in bulk is often preferable.
        /// </summary>

        public static unsafe delegate* <ulong,int*,IntPtr*,ulong*,int*,int*,int*,void> gmshModelMeshGetElement; gmshModelMeshGetElement = (delegate* <ulong,int*,IntPtr*,ulong*,int*,int*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetElement");
        
        /// <summary>
        /// Search the mesh for an element located at coordinates (`x', `y', `z'). This
        /// function performs a search in a spatial octree. If an element is found,
        /// return its tag, type and node tags, as well as the local coordinates (`u',
        /// `v', `w') within the reference element corresponding to search location. If
        /// `dim' is &gt;= 0, only search for elements of the given dimension. If `strict'
        /// is not set, use a tolerance to find elements near the search location.
        /// </summary>

        public static unsafe delegate* <double,double,double,ulong*,int*,IntPtr*,ulong*,double*,double*,double*,int,int,int*,void> gmshModelMeshGetElementByCoordinates; gmshModelMeshGetElementByCoordinates = (delegate* <double,double,double,ulong*,int*,IntPtr*,ulong*,double*,double*,double*,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetElementByCoordinates");
        
        /// <summary>
        /// Search the mesh for element(s) located at coordinates (`x', `y', `z'). This
        /// function performs a search in a spatial octree. Return the tags of all
        /// found elements in `elementTags'. Additional information about the elements
        /// can be accessed through `getElement' and `getLocalCoordinatesInElement'. If
        /// `dim' is &gt;= 0, only search for elements of the given dimension. If `strict'
        /// is not set, use a tolerance to find elements near the search location.
        /// </summary>

        public static unsafe delegate* <double,double,double,IntPtr*,ulong*,int,int,int*,void> gmshModelMeshGetElementsByCoordinates; gmshModelMeshGetElementsByCoordinates = (delegate* <double,double,double,IntPtr*,ulong*,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetElementsByCoordinates");
        
        /// <summary>
        /// Return the local coordinates (`u', `v', `w') within the element
        /// `elementTag' corresponding to the model coordinates (`x', `y', `z'). This
        /// function relies on an internal cache (a vector in case of dense element
        /// numbering, a map otherwise); for large meshes accessing elements in bulk is
        /// often preferable.
        /// </summary>

        public static unsafe delegate* <ulong,double,double,double,double*,double*,double*,int*,void> gmshModelMeshGetLocalCoordinatesInElement; gmshModelMeshGetLocalCoordinatesInElement = (delegate* <ulong,double,double,double,double*,double*,double*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetLocalCoordinatesInElement");
        
        /// <summary>
        /// Get the types of elements in the entity of dimension `dim' and tag `tag'.
        /// If `tag' 
        /// &lt;
        /// 0, get the types for all entities of dimension `dim'. If `dim'
        /// and `tag' are negative, get all the types in the mesh.
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,int,int,int*,void> gmshModelMeshGetElementTypes; gmshModelMeshGetElementTypes = (delegate* <IntPtr*,ulong*,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetElementTypes");
        
        /// <summary>
        /// Return an element type given its family name `familyName' ("Point", "Line",
        /// "Triangle", "Quadrangle", "Tetrahedron", "Pyramid", "Prism", "Hexahedron")
        /// and polynomial order `order'. If `serendip' is true, return the
        /// corresponding serendip element type (element without interior nodes).
        /// </summary>

        public static unsafe delegate* <nint,int,int,int*,int> gmshModelMeshGetElementType; gmshModelMeshGetElementType = (delegate* <nint,int,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetElementType");
        
        /// <summary>
        /// Get the properties of an element of type `elementType': its name
        /// (`elementName'), dimension (`dim'), order (`order'), number of nodes
        /// (`numNodes'), local coordinates of the nodes in the reference element
        /// (`localNodeCoord' vector, of length `dim' times `numNodes') and number of
        /// primary (first order) nodes (`numPrimaryNodes').
        /// </summary>

        public static unsafe delegate* <int,IntPtr*,int*,int*,int*,IntPtr*,ulong*,int*,int*,void> gmshModelMeshGetElementProperties; gmshModelMeshGetElementProperties = (delegate* <int,IntPtr*,int*,int*,int*,IntPtr*,ulong*,int*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetElementProperties");
        
        /// <summary>
        /// Get the elements of type `elementType' classified on the entity of tag
        /// `tag'. If `tag' 
        /// &lt;
        /// 0, get the elements for all entities. `elementTags' is a
        /// vector containing the tags (unique, strictly positive identifiers) of the
        /// elements of the corresponding type. `nodeTags' is a vector of length equal
        /// to the number of elements of the given type times the number N of nodes for
        /// this type of element, that contains the node tags of all the elements of
        /// the given type, concatenated: [e1n1, e1n2, ..., e1nN, e2n1, ...]. If
        /// `numTasks' &gt; 1, only compute and return the part of the data indexed by
        /// `task'.
        /// </summary>

        public static unsafe delegate* <int,IntPtr*,ulong*,IntPtr*,ulong*,int,ulong,ulong,int*,void> gmshModelMeshGetElementsByType; gmshModelMeshGetElementsByType = (delegate* <int,IntPtr*,ulong*,IntPtr*,ulong*,int,ulong,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetElementsByType");
        
        /// <summary>
        /// Get the maximum tag `maxTag' of an element in the mesh.
        /// </summary>

        public static unsafe delegate* <ulong*,int*,void> gmshModelMeshGetMaxElementTag; gmshModelMeshGetMaxElementTag = (delegate* <ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetMaxElementTag");
        
        /// <summary>
        /// Preallocate data before calling `getElementsByType' with `numTasks' &gt; 1.
        /// For C and C++ only.
        /// </summary>

        public static unsafe delegate* <int,int,int,IntPtr*,ulong*,IntPtr*,ulong*,int,int*,void> gmshModelMeshPreallocateElementsByType; gmshModelMeshPreallocateElementsByType = (delegate* <int,int,int,IntPtr*,ulong*,IntPtr*,ulong*,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshPreallocateElementsByType");
        
        /// <summary>
        /// Get the quality `elementQualities' of the elements with tags `elementTags'.
        /// `qualityType' is the requested quality measure: "minSJ" for the minimal
        /// scaled jacobien, "minSICN" for the minimal signed inverted condition
        /// number, "minSIGE" for the signed inverted gradient error, "gamma" for the
        /// ratio of the inscribed to circumcribed sphere radius, "volume" for the
        /// volume. If `numTasks' &gt; 1, only compute and return the part of the data
        /// indexed by `task'.
        /// </summary>

        public static unsafe delegate* <ulong*,ulong,IntPtr*,ulong*,nint,ulong,ulong,int*,void> gmshModelMeshGetElementQualities; gmshModelMeshGetElementQualities = (delegate* <ulong*,ulong,IntPtr*,ulong*,nint,ulong,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetElementQualities");
        
        /// <summary>
        /// Add elements classified on the entity of dimension `dim' and tag `tag'.
        /// `types' contains the MSH types of the elements (e.g. `2' for 3-node
        /// triangles: see the Gmsh reference manual). `elementTags' is a vector of the
        /// same length as `types'; each entry is a vector containing the tags (unique,
        /// strictly positive identifiers) of the elements of the corresponding type.
        /// `nodeTags' is also a vector of the same length as `types'; each entry is a
        /// vector of length equal to the number of elements of the given type times
        /// the number N of nodes per element, that contains the node tags of all the
        /// elements of the given type, concatenated: [e1n1, e1n2, ..., e1nN, e2n1,
        /// ...].
        /// </summary>

        public static unsafe delegate* <int,int,int*,ulong,IntPtr*,ulong*,ulong,IntPtr*,ulong*,ulong,int*,void> gmshModelMeshAddElements; gmshModelMeshAddElements = (delegate* <int,int,int*,ulong,IntPtr*,ulong*,ulong,IntPtr*,ulong*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshAddElements");
        
        /// <summary>
        /// Add elements of type `elementType' classified on the entity of tag `tag'.
        /// `elementTags' contains the tags (unique, strictly positive identifiers) of
        /// the elements of the corresponding type. `nodeTags' is a vector of length
        /// equal to the number of elements times the number N of nodes per element,
        /// that contains the node tags of all the elements, concatenated: [e1n1, e1n2,
        /// ..., e1nN, e2n1, ...]. If the `elementTag' vector is empty, new tags are
        /// automatically assigned to the elements.
        /// </summary>

        public static unsafe delegate* <int,int,ulong*,ulong,ulong*,ulong,int*,void> gmshModelMeshAddElementsByType; gmshModelMeshAddElementsByType = (delegate* <int,int,ulong*,ulong,ulong*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshAddElementsByType");
        
        /// <summary>
        /// Get the numerical quadrature information for the given element type
        /// `elementType' and integration rule `integrationType', where
        /// `integrationType' concatenates the integration rule family name with the
        /// desired order (e.g. "Gauss4" for a quadrature suited for integrating 4th
        /// order polynomials). The "CompositeGauss" family uses tensor-product rules
        /// based the 1D Gauss-Legendre rule; the "Gauss" family uses an economic
        /// scheme when available (i.e. with a minimal number of points), and falls
        /// back to "CompositeGauss" otherwise. Note that integration points for the
        /// "Gauss" family can fall outside of the reference element for high-order
        /// rules. `localCoord' contains the u, v, w coordinates of the G integration
        /// points in the reference element: [g1u, g1v, g1w, ..., gGu, gGv, gGw].
        /// `weights' contains the associated weights: [g1q, ..., gGq].
        /// </summary>

        public static unsafe delegate* <int,nint,IntPtr*,ulong*,IntPtr*,ulong*,int*,void> gmshModelMeshGetIntegrationPoints; gmshModelMeshGetIntegrationPoints = (delegate* <int,nint,IntPtr*,ulong*,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetIntegrationPoints");
        
        /// <summary>
        /// Get the Jacobians of all the elements of type `elementType' classified on
        /// the entity of tag `tag', at the G evaluation points `localCoord' given as
        /// concatenated triplets of coordinates in the reference element [g1u, g1v,
        /// g1w, ..., gGu, gGv, gGw]. Data is returned by element, with elements in the
        /// same order as in `getElements' and `getElementsByType'. `jacobians'
        /// contains for each element the 9 entries of the 3x3 Jacobian matrix at each
        /// evaluation point. The matrix is returned by column: [e1g1Jxu, e1g1Jyu,
        /// e1g1Jzu, e1g1Jxv, ..., e1g1Jzw, e1g2Jxu, ..., e1gGJzw, e2g1Jxu, ...], with
        /// Jxu=dx/du, Jyu=dy/du, etc. `determinants' contains for each element the
        /// determinant of the Jacobian matrix at each evaluation point: [e1g1, e1g2,
        /// ... e1gG, e2g1, ...]. `coord' contains for each element the x, y, z
        /// coordinates of the evaluation points. If `tag' 
        /// &lt;
        /// 0, get the Jacobian data
        /// for all entities. If `numTasks' &gt; 1, only compute and return the part of
        /// the data indexed by `task'.
        /// </summary>

        public static unsafe delegate* <int,double*,ulong,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int,ulong,ulong,int*,void> gmshModelMeshGetJacobians; gmshModelMeshGetJacobians = (delegate* <int,double*,ulong,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int,ulong,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetJacobians");
        
        /// <summary>
        /// Preallocate data before calling `getJacobians' with `numTasks' &gt; 1. For C
        /// and C++ only.
        /// </summary>

        public static unsafe delegate* <int,int,int,int,int,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int,int*,void> gmshModelMeshPreallocateJacobians; gmshModelMeshPreallocateJacobians = (delegate* <int,int,int,int,int,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshPreallocateJacobians");
        
        /// <summary>
        /// Get the Jacobian for a single element `elementTag', at the G evaluation
        /// points `localCoord' given as concatenated triplets of coordinates in the
        /// reference element [g1u, g1v, g1w, ..., gGu, gGv, gGw]. `jacobians' contains
        /// the 9 entries of the 3x3 Jacobian matrix at each evaluation point. The
        /// matrix is returned by column: [e1g1Jxu, e1g1Jyu, e1g1Jzu, e1g1Jxv, ...,
        /// e1g1Jzw, e1g2Jxu, ..., e1gGJzw, e2g1Jxu, ...], with Jxu=dx/du, Jyu=dy/du,
        /// etc. `determinants' contains the determinant of the Jacobian matrix at each
        /// evaluation point. `coord' contains the x, y, z coordinates of the
        /// evaluation points. This function relies on an internal cache (a vector in
        /// case of dense element numbering, a map otherwise); for large meshes
        /// accessing Jacobians in bulk is often preferable.
        /// </summary>

        public static unsafe delegate* <ulong,double*,ulong,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int*,void> gmshModelMeshGetJacobian; gmshModelMeshGetJacobian = (delegate* <ulong,double*,ulong,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetJacobian");
        
        /// <summary>
        /// Get the basis functions of the element of type `elementType' at the
        /// evaluation points `localCoord' (given as concatenated triplets of
        /// coordinates in the reference element [g1u, g1v, g1w, ..., gGu, gGv, gGw]),
        /// for the function space `functionSpaceType'. Currently supported function
        /// spaces include "Lagrange" and "GradLagrange" for isoparametric Lagrange
        /// basis functions and their gradient in the u, v, w coordinates of the
        /// reference element; "LagrangeN" and "GradLagrangeN", with N = 1, 2, ..., for
        /// N-th order Lagrange basis functions; "H1LegendreN" and "GradH1LegendreN",
        /// with N = 1, 2, ..., for N-th order hierarchical H1 Legendre functions;
        /// "HcurlLegendreN" and "CurlHcurlLegendreN", with N = 1, 2, ..., for N-th
        /// order curl-conforming basis functions. `numComponents' returns the number C
        /// of components of a basis function (e.g. 1 for scalar functions and 3 for
        /// vector functions). `basisFunctions' returns the value of the N basis
        /// functions at the evaluation points, i.e. [g1f1, g1f2, ..., g1fN, g2f1, ...]
        /// when C == 1 or [g1f1u, g1f1v, g1f1w, g1f2u, ..., g1fNw, g2f1u, ...] when C
        /// == 3. For basis functions that depend on the orientation of the elements,
        /// all values for the first orientation are returned first, followed by values
        /// for the second, etc. `numOrientations' returns the overall number of
        /// orientations. If `wantedOrientations' is not empty, only return the values
        /// for the desired orientation indices.
        /// </summary>

        public static unsafe delegate* <int,double*,ulong,nint,int*,IntPtr*,ulong*,int*,int*,ulong,int*,void> gmshModelMeshGetBasisFunctions; gmshModelMeshGetBasisFunctions = (delegate* <int,double*,ulong,nint,int*,IntPtr*,ulong*,int*,int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetBasisFunctions");
        
        /// <summary>
        /// Get the orientation index of the elements of type `elementType' in the
        /// entity of tag `tag'. The arguments have the same meaning as in
        /// `getBasisFunctions'. `basisFunctionsOrientation' is a vector giving for
        /// each element the orientation index in the values returned by
        /// `getBasisFunctions'. For Lagrange basis functions the call is superfluous
        /// as it will return a vector of zeros.
        /// </summary>

        public static unsafe delegate* <int,nint,IntPtr*,ulong*,int,ulong,ulong,int*,void> gmshModelMeshGetBasisFunctionsOrientation; gmshModelMeshGetBasisFunctionsOrientation = (delegate* <int,nint,IntPtr*,ulong*,int,ulong,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetBasisFunctionsOrientation");
        
        /// <summary>
        /// Get the orientation of a single element `elementTag'.
        /// </summary>

        public static unsafe delegate* <ulong,nint,int*,int*,void> gmshModelMeshGetBasisFunctionsOrientationForElement; gmshModelMeshGetBasisFunctionsOrientationForElement = (delegate* <ulong,nint,int*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetBasisFunctionsOrientationForElement");
        
        /// <summary>
        /// Get the number of possible orientations for elements of type `elementType'
        /// and function space named `functionSpaceType'.
        /// </summary>

        public static unsafe delegate* <int,nint,int*,int> gmshModelMeshGetNumberOfOrientations; gmshModelMeshGetNumberOfOrientations = (delegate* <int,nint,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetNumberOfOrientations");
        
        /// <summary>
        /// Preallocate data before calling `getBasisFunctionsOrientation' with
        /// `numTasks' &gt; 1. For C and C++ only.
        /// </summary>

        public static unsafe delegate* <int,IntPtr*,ulong*,int,int*,void> gmshModelMeshPreallocateBasisFunctionsOrientation; gmshModelMeshPreallocateBasisFunctionsOrientation = (delegate* <int,IntPtr*,ulong*,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshPreallocateBasisFunctionsOrientation");
        
        /// <summary>
        /// Get the global unique mesh edge identifiers `edgeTags' and orientations
        /// `edgeOrientation' for an input list of node tag pairs defining these edges,
        /// concatenated in the vector `nodeTags'. Mesh edges are created e.g. by
        /// `createEdges()', `getKeys()' or `addEdges()'. The reference positive
        /// orientation is n1 
        /// &lt;
        /// n2, where n1 and n2 are the tags of the two edge nodes,
        /// which corresponds to the local orientation of edge-based basis functions as
        /// well.
        /// </summary>

        public static unsafe delegate* <ulong*,ulong,IntPtr*,ulong*,IntPtr*,ulong*,int*,void> gmshModelMeshGetEdges; gmshModelMeshGetEdges = (delegate* <ulong*,ulong,IntPtr*,ulong*,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetEdges");
        
        /// <summary>
        /// Get the global unique mesh face identifiers `faceTags' and orientations
        /// `faceOrientations' for an input list of node tag triplets (if `faceType' ==
        /// 3) or quadruplets (if `faceType' == 4) defining these faces, concatenated
        /// in the vector `nodeTags'. Mesh faces are created e.g. by `createFaces()',
        /// `getKeys()' or `addFaces()'.
        /// </summary>

        public static unsafe delegate* <int,ulong*,ulong,IntPtr*,ulong*,IntPtr*,ulong*,int*,void> gmshModelMeshGetFaces; gmshModelMeshGetFaces = (delegate* <int,ulong*,ulong,IntPtr*,ulong*,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetFaces");
        
        /// <summary>
        /// Create unique mesh edges for the entities `dimTags'.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int*,void> gmshModelMeshCreateEdges; gmshModelMeshCreateEdges = (delegate* <int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshCreateEdges");
        
        /// <summary>
        /// Create unique mesh faces for the entities `dimTags'.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int*,void> gmshModelMeshCreateFaces; gmshModelMeshCreateFaces = (delegate* <int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshCreateFaces");
        
        /// <summary>
        /// Get the global unique identifiers `edgeTags' and the nodes `edgeNodes' of
        /// the edges in the mesh. Mesh edges are created e.g. by `createEdges()',
        /// `getKeys()' or addEdges().
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,IntPtr*,ulong*,int*,void> gmshModelMeshGetAllEdges; gmshModelMeshGetAllEdges = (delegate* <IntPtr*,ulong*,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetAllEdges");
        
        /// <summary>
        /// Get the global unique identifiers `faceTags' and the nodes `faceNodes' of
        /// the faces of type `faceType' in the mesh. Mesh faces are created e.g. by
        /// `createFaces()', `getKeys()' or addFaces().
        /// </summary>

        public static unsafe delegate* <int,IntPtr*,ulong*,IntPtr*,ulong*,int*,void> gmshModelMeshGetAllFaces; gmshModelMeshGetAllFaces = (delegate* <int,IntPtr*,ulong*,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetAllFaces");
        
        /// <summary>
        /// Add mesh edges defined by their global unique identifiers `edgeTags' and
        /// their nodes `edgeNodes'.
        /// </summary>

        public static unsafe delegate* <ulong*,ulong,ulong*,ulong,int*,void> gmshModelMeshAddEdges; gmshModelMeshAddEdges = (delegate* <ulong*,ulong,ulong*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshAddEdges");
        
        /// <summary>
        /// Add mesh faces of type `faceType' defined by their global unique
        /// identifiers `faceTags' and their nodes `faceNodes'.
        /// </summary>

        public static unsafe delegate* <int,ulong*,ulong,ulong*,ulong,int*,void> gmshModelMeshAddFaces; gmshModelMeshAddFaces = (delegate* <int,ulong*,ulong,ulong*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshAddFaces");
        
        /// <summary>
        /// Generate the pair of keys for the elements of type `elementType' in the
        /// entity of tag `tag', for the `functionSpaceType' function space. Each pair
        /// (`typeKey', `entityKey') uniquely identifies a basis function in the
        /// function space. If `returnCoord' is set, the `coord' vector contains the x,
        /// y, z coordinates locating basis functions for sorting purposes. Warning:
        /// this is an experimental feature and will probably change in a future
        /// release.
        /// </summary>

        public static unsafe delegate* <int,nint,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int,int,int*,void> gmshModelMeshGetKeys; gmshModelMeshGetKeys = (delegate* <int,nint,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetKeys");
        
        /// <summary>
        /// Get the pair of keys for a single element `elementTag'.
        /// </summary>

        public static unsafe delegate* <ulong,nint,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int,int*,void> gmshModelMeshGetKeysForElement; gmshModelMeshGetKeysForElement = (delegate* <ulong,nint,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetKeysForElement");
        
        /// <summary>
        /// Get the number of keys by elements of type `elementType' for function space
        /// named `functionSpaceType'.
        /// </summary>

        public static unsafe delegate* <int,nint,int*,int> gmshModelMeshGetNumberOfKeys; gmshModelMeshGetNumberOfKeys = (delegate* <int,nint,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetNumberOfKeys");
        
        /// <summary>
        /// Get information about the pair of `keys'. `infoKeys' returns information
        /// about the functions associated with the pairs (`typeKeys', `entityKey').
        /// `infoKeys[0].first' describes the type of function (0 for  vertex function,
        /// 1 for edge function, 2 for face function and 3 for bubble function).
        /// `infoKeys[0].second' gives the order of the function associated with the
        /// key. Warning: this is an experimental feature and will probably change in a
        /// future release.
        /// </summary>

        public static unsafe delegate* <int*,ulong,ulong*,ulong,int,nint,IntPtr*,ulong*,int*,void> gmshModelMeshGetKeysInformation; gmshModelMeshGetKeysInformation = (delegate* <int*,ulong,ulong*,ulong,int,nint,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetKeysInformation");
        
        /// <summary>
        /// Get the barycenters of all elements of type `elementType' classified on the
        /// entity of tag `tag'. If `primary' is set, only the primary nodes of the
        /// elements are taken into account for the barycenter calculation. If `fast'
        /// is set, the function returns the sum of the primary node coordinates
        /// (without normalizing by the number of nodes). If `tag' 
        /// &lt;
        /// 0, get the
        /// barycenters for all entities. If `numTasks' &gt; 1, only compute and return
        /// the part of the data indexed by `task'.
        /// </summary>

        public static unsafe delegate* <int,int,int,int,IntPtr*,ulong*,ulong,ulong,int*,void> gmshModelMeshGetBarycenters; gmshModelMeshGetBarycenters = (delegate* <int,int,int,int,IntPtr*,ulong*,ulong,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetBarycenters");
        
        /// <summary>
        /// Preallocate data before calling `getBarycenters' with `numTasks' &gt; 1. For C
        /// and C++ only.
        /// </summary>

        public static unsafe delegate* <int,IntPtr*,ulong*,int,int*,void> gmshModelMeshPreallocateBarycenters; gmshModelMeshPreallocateBarycenters = (delegate* <int,IntPtr*,ulong*,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshPreallocateBarycenters");
        
        /// <summary>
        /// Get the nodes on the edges of all elements of type `elementType' classified
        /// on the entity of tag `tag'. `nodeTags' contains the node tags of the edges
        /// for all the elements: [e1a1n1, e1a1n2, e1a2n1, ...]. Data is returned by
        /// element, with elements in the same order as in `getElements' and
        /// `getElementsByType'. If `primary' is set, only the primary (begin/end)
        /// nodes of the edges are returned. If `tag' 
        /// &lt;
        /// 0, get the edge nodes for all
        /// entities. If `numTasks' &gt; 1, only compute and return the part of the data
        /// indexed by `task'.
        /// </summary>

        public static unsafe delegate* <int,IntPtr*,ulong*,int,int,ulong,ulong,int*,void> gmshModelMeshGetElementEdgeNodes; gmshModelMeshGetElementEdgeNodes = (delegate* <int,IntPtr*,ulong*,int,int,ulong,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetElementEdgeNodes");
        
        /// <summary>
        /// Get the nodes on the faces of type `faceType' (3 for triangular faces, 4
        /// for quadrangular faces) of all elements of type `elementType' classified on
        /// the entity of tag `tag'. `nodeTags' contains the node tags of the faces for
        /// all elements: [e1f1n1, ..., e1f1nFaceType, e1f2n1, ...]. Data is returned
        /// by element, with elements in the same order as in `getElements' and
        /// `getElementsByType'. If `primary' is set, only the primary (corner) nodes
        /// of the faces are returned. If `tag' 
        /// &lt;
        /// 0, get the face nodes for all
        /// entities. If `numTasks' &gt; 1, only compute and return the part of the data
        /// indexed by `task'.
        /// </summary>

        public static unsafe delegate* <int,int,IntPtr*,ulong*,int,int,ulong,ulong,int*,void> gmshModelMeshGetElementFaceNodes; gmshModelMeshGetElementFaceNodes = (delegate* <int,int,IntPtr*,ulong*,int,int,ulong,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetElementFaceNodes");
        
        /// <summary>
        /// Get the ghost elements `elementTags' and their associated `partitions'
        /// stored in the ghost entity of dimension `dim' and tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,int,IntPtr*,ulong*,IntPtr*,ulong*,int*,void> gmshModelMeshGetGhostElements; gmshModelMeshGetGhostElements = (delegate* <int,int,IntPtr*,ulong*,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetGhostElements");
        
        /// <summary>
        /// Set a mesh size constraint on the model entities `dimTags'. Currently only
        /// entities of dimension 0 (points) are handled.
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,int*,void> gmshModelMeshSetSize; gmshModelMeshSetSize = (delegate* <int*,ulong,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSetSize");
        
        /// <summary>
        /// Get the mesh size constraints (if any) associated with the model entities
        /// `dimTags'. A zero entry in the output `sizes' vector indicates that no size
        /// constraint is specified on the corresponding entity.
        /// </summary>

        public static unsafe delegate* <int*,ulong,IntPtr*,ulong*,int*,void> gmshModelMeshGetSizes; gmshModelMeshGetSizes = (delegate* <int*,ulong,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetSizes");
        
        /// <summary>
        /// Set mesh size constraints at the given parametric points `parametricCoord'
        /// on the model entity of dimension `dim' and tag `tag'. Currently only
        /// entities of dimension 1 (lines) are handled.
        /// </summary>

        public static unsafe delegate* <int,int,double*,ulong,double*,ulong,int*,void> gmshModelMeshSetSizeAtParametricPoints; gmshModelMeshSetSizeAtParametricPoints = (delegate* <int,int,double*,ulong,double*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSetSizeAtParametricPoints");
        
        /// <summary>
        /// Set a mesh size callback for the current model. The callback function
        /// should take six arguments as input (`dim', `tag', `x', `y', `z' and `lc').
        /// The first two integer arguments correspond to the dimension `dim' and tag
        /// `tag' of the entity being meshed. The next four double precision arguments
        /// correspond to the coordinates `x', `y' and `z' around which to prescribe
        /// the mesh size and to the mesh size `lc' that would be prescribed if the
        /// callback had not been called. The callback function should return a double
        /// precision number specifying the desired mesh size; returning `lc' is
        /// equivalent to a no-op.
        /// </summary>

        public static unsafe delegate* <libnative.callback_delegate,void*,int*,void> gmshModelMeshSetSizeCallback; gmshModelMeshSetSizeCallback = (delegate* <libnative.callback_delegate,void*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSetSizeCallback");
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double callback_delegate(libnative.callback_delegate callback, void* callback_data, int* ierr);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double callback_delegate(int dim, int tag, double x, double y, double z, double lc, void* data);
        
        /// <summary>
        /// Remove the mesh size callback from the current model.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshModelMeshRemoveSizeCallback; gmshModelMeshRemoveSizeCallback = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshRemoveSizeCallback");
        
        /// <summary>
        /// Set a transfinite meshing constraint on the curve `tag', with `numNodes'
        /// nodes distributed according to `meshType' and `coef'. Currently supported
        /// types are "Progression" (geometrical progression with power `coef'), "Bump"
        /// (refinement toward both extremities of the curve) and "Beta" (beta law).
        /// </summary>

        public static unsafe delegate* <int,int,nint,double,int*,void> gmshModelMeshSetTransfiniteCurve; gmshModelMeshSetTransfiniteCurve = (delegate* <int,int,nint,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSetTransfiniteCurve");
        
        /// <summary>
        /// Set a transfinite meshing constraint on the surface `tag'. `arrangement'
        /// describes the arrangement of the triangles when the surface is not flagged
        /// as recombined: currently supported values are "Left", "Right",
        /// "AlternateLeft" and "AlternateRight". `cornerTags' can be used to specify
        /// the (3 or 4) corners of the transfinite interpolation explicitly;
        /// specifying the corners explicitly is mandatory if the surface has more that
        /// 3 or 4 points on its boundary.
        /// </summary>

        public static unsafe delegate* <int,nint,int*,ulong,int*,void> gmshModelMeshSetTransfiniteSurface; gmshModelMeshSetTransfiniteSurface = (delegate* <int,nint,int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSetTransfiniteSurface");
        
        /// <summary>
        /// Set a transfinite meshing constraint on the surface `tag'. `cornerTags' can
        /// be used to specify the (6 or 8) corners of the transfinite interpolation
        /// explicitly.
        /// </summary>

        public static unsafe delegate* <int,int*,ulong,int*,void> gmshModelMeshSetTransfiniteVolume; gmshModelMeshSetTransfiniteVolume = (delegate* <int,int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSetTransfiniteVolume");
        
        /// <summary>
        /// Set transfinite meshing constraints on the model entities in `dimTag'.
        /// Transfinite meshing constraints are added to the curves of the quadrangular
        /// surfaces and to the faces of 6-sided volumes. Quadragular faces with a
        /// corner angle superior to `cornerAngle' (in radians) are ignored. The number
        /// of points is automatically determined from the sizing constraints. If
        /// `dimTag' is empty, the constraints are applied to all entities in the
        /// model. If `recombine' is true, the recombine flag is automatically set on
        /// the transfinite surfaces.
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,int,int*,void> gmshModelMeshSetTransfiniteAutomatic; gmshModelMeshSetTransfiniteAutomatic = (delegate* <int*,ulong,double,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSetTransfiniteAutomatic");
        
        /// <summary>
        /// Set a recombination meshing constraint on the model entity of dimension
        /// `dim' and tag `tag'. Currently only entities of dimension 2 (to recombine
        /// triangles into quadrangles) are supported; `angle' specifies the threshold
        /// angle for the simple recombination algorithm..
        /// </summary>

        public static unsafe delegate* <int,int,double,int*,void> gmshModelMeshSetRecombine; gmshModelMeshSetRecombine = (delegate* <int,int,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSetRecombine");
        
        /// <summary>
        /// Set a smoothing meshing constraint on the model entity of dimension `dim'
        /// and tag `tag'. `val' iterations of a Laplace smoother are applied.
        /// </summary>

        public static unsafe delegate* <int,int,int,int*,void> gmshModelMeshSetSmoothing; gmshModelMeshSetSmoothing = (delegate* <int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSetSmoothing");
        
        /// <summary>
        /// Set a reverse meshing constraint on the model entity of dimension `dim' and
        /// tag `tag'. If `val' is true, the mesh orientation will be reversed with
        /// respect to the natural mesh orientation (i.e. the orientation consistent
        /// with the orientation of the geometry). If `val' is false, the mesh is left
        /// as-is.
        /// </summary>

        public static unsafe delegate* <int,int,int,int*,void> gmshModelMeshSetReverse; gmshModelMeshSetReverse = (delegate* <int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSetReverse");
        
        /// <summary>
        /// Set the meshing algorithm on the model entity of dimension `dim' and tag
        /// `tag'. Currently only supported for `dim' == 2.
        /// </summary>

        public static unsafe delegate* <int,int,int,int*,void> gmshModelMeshSetAlgorithm; gmshModelMeshSetAlgorithm = (delegate* <int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSetAlgorithm");
        
        /// <summary>
        /// Force the mesh size to be extended from the boundary, or not, for the model
        /// entity of dimension `dim' and tag `tag'. Currently only supported for `dim'
        /// == 2.
        /// </summary>

        public static unsafe delegate* <int,int,int,int*,void> gmshModelMeshSetSizeFromBoundary; gmshModelMeshSetSizeFromBoundary = (delegate* <int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSetSizeFromBoundary");
        
        /// <summary>
        /// Set a compound meshing constraint on the model entities of dimension `dim'
        /// and tags `tags'. During meshing, compound entities are treated as a single
        /// discrete entity, which is automatically reparametrized.
        /// </summary>

        public static unsafe delegate* <int,int*,ulong,int*,void> gmshModelMeshSetCompound; gmshModelMeshSetCompound = (delegate* <int,int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSetCompound");
        
        /// <summary>
        /// Set meshing constraints on the bounding surfaces of the volume of tag `tag'
        /// so that all surfaces are oriented with outward pointing normals; and if a
        /// mesh already exists, reorient it. Currently only available with the
        /// OpenCASCADE kernel, as it relies on the STL triangulation.
        /// </summary>

        public static unsafe delegate* <int,int*,void> gmshModelMeshSetOutwardOrientation; gmshModelMeshSetOutwardOrientation = (delegate* <int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSetOutwardOrientation");
        
        /// <summary>
        /// Remove all meshing constraints from the model entities `dimTags'. If
        /// `dimTags' is empty, remove all constraings.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int*,void> gmshModelMeshRemoveConstraints; gmshModelMeshRemoveConstraints = (delegate* <int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshRemoveConstraints");
        
        /// <summary>
        /// Embed the model entities of dimension `dim' and tags `tags' in the
        /// (`inDim', `inTag') model entity. The dimension `dim' can 0, 1 or 2 and must
        /// be strictly smaller than `inDim', which must be either 2 or 3. The embedded
        /// entities should not intersect each other or be part of the boundary of the
        /// entity `inTag', whose mesh will conform to the mesh of the embedded
        /// entities. With the OpenCASCADE kernel, if the `fragment' operation is
        /// applied to entities of different dimensions, the lower dimensional entities
        /// will be automatically embedded in the higher dimensional entities if they
        /// are not on their boundary.
        /// </summary>

        public static unsafe delegate* <int,int*,ulong,int,int,int*,void> gmshModelMeshEmbed; gmshModelMeshEmbed = (delegate* <int,int*,ulong,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshEmbed");
        
        /// <summary>
        /// Remove embedded entities from the model entities `dimTags'. if `dim' is &gt;=
        /// 0, only remove embedded entities of the given dimension (e.g. embedded
        /// points if `dim' == 0).
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int*,void> gmshModelMeshRemoveEmbedded; gmshModelMeshRemoveEmbedded = (delegate* <int*,ulong,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshRemoveEmbedded");
        
        /// <summary>
        /// Get the entities (if any) embedded in the model entity of dimension `dim'
        /// and tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,int,IntPtr*,ulong*,int*,void> gmshModelMeshGetEmbedded; gmshModelMeshGetEmbedded = (delegate* <int,int,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetEmbedded");
        
        /// <summary>
        /// Reorder the elements of type `elementType' classified on the entity of tag
        /// `tag' according to `ordering'.
        /// </summary>

        public static unsafe delegate* <int,int,ulong*,ulong,int*,void> gmshModelMeshReorderElements; gmshModelMeshReorderElements = (delegate* <int,int,ulong*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshReorderElements");
        
        /// <summary>
        /// Renumber the node tags in a continuous sequence.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshModelMeshRenumberNodes; gmshModelMeshRenumberNodes = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshRenumberNodes");
        
        /// <summary>
        /// Renumber the element tags in a continuous sequence.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshModelMeshRenumberElements; gmshModelMeshRenumberElements = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshRenumberElements");
        
        /// <summary>
        /// Set the meshes of the entities of dimension `dim' and tag `tags' as
        /// periodic copies of the meshes of entities `tagsMaster', using the affine
        /// transformation specified in `affineTransformation' (16 entries of a 4x4
        /// matrix, by row). If used after meshing, generate the periodic node
        /// correspondence information assuming the meshes of entities `tags'
        /// effectively match the meshes of entities `tagsMaster' (useful for
        /// structured and extruded meshes). Currently only available for
        /// </summary>
        /// <remarks>
        /// @code {dim} ==
        ///  1 and @code{dim} == 2. 
        /// 
        /// @endcode
        /// </remarks>

        public static unsafe delegate* <int,int*,ulong,int*,ulong,double*,ulong,int*,void> gmshModelMeshSetPeriodic; gmshModelMeshSetPeriodic = (delegate* <int,int*,ulong,int*,ulong,double*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSetPeriodic");
        
        /// <summary>
        /// Get master entities `tagsMaster' for the entities of dimension `dim' and
        /// tags `tags'.
        /// </summary>

        public static unsafe delegate* <int,int*,ulong,IntPtr*,ulong*,int*,void> gmshModelMeshGetPeriodic; gmshModelMeshGetPeriodic = (delegate* <int,int*,ulong,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetPeriodic");
        
        /// <summary>
        /// Get the master entity `tagMaster', the node tags `nodeTags' and their
        /// corresponding master node tags `nodeTagsMaster', and the affine transform
        /// `affineTransform' for the entity of dimension `dim' and tag `tag'. If
        /// `includeHighOrderNodes' is set, include high-order nodes in the returned
        /// data.
        /// </summary>

        public static unsafe delegate* <int,int,int*,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int,int*,void> gmshModelMeshGetPeriodicNodes; gmshModelMeshGetPeriodicNodes = (delegate* <int,int,int*,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetPeriodicNodes");
        
        /// <summary>
        /// Get the master entity `tagMaster' and the key pairs (`typeKeyMaster',
        /// `entityKeyMaster') corresponding to the entity `tag' and the key pairs
        /// (`typeKey', `entityKey') for the elements of type `elementType' and
        /// function space type `functionSpaceType'. If `returnCoord' is set, the
        /// `coord' and `coordMaster' vectors contain the x, y, z coordinates locating
        /// basis functions for sorting purposes.
        /// </summary>

        public static unsafe delegate* <int,nint,int,int*,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int,int*,void> gmshModelMeshGetPeriodicKeys; gmshModelMeshGetPeriodicKeys = (delegate* <int,nint,int,int*,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetPeriodicKeys");
        
        /// <summary>
        /// Import the model STL representation (if available) as the current mesh.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshModelMeshImportStl; gmshModelMeshImportStl = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshImportStl");
        
        /// <summary>
        /// Get the `tags' of any duplicate nodes in the mesh of the entities
        /// `dimTags'. If `dimTags' is empty, consider the whole mesh.
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,int*,ulong,int*,void> gmshModelMeshGetDuplicateNodes; gmshModelMeshGetDuplicateNodes = (delegate* <IntPtr*,ulong*,int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshGetDuplicateNodes");
        
        /// <summary>
        /// Remove duplicate nodes in the mesh of the entities `dimTags'. If `dimTags'
        /// is empty, consider the whole mesh.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int*,void> gmshModelMeshRemoveDuplicateNodes; gmshModelMeshRemoveDuplicateNodes = (delegate* <int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshRemoveDuplicateNodes");
        
        /// <summary>
        /// Split (into two triangles) all quadrangles in surface `tag' whose quality
        /// is lower than `quality'. If `tag' 
        /// &lt;
        /// 0, split quadrangles in all surfaces.
        /// </summary>

        public static unsafe delegate* <double,int,int*,void> gmshModelMeshSplitQuadrangles; gmshModelMeshSplitQuadrangles = (delegate* <double,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSplitQuadrangles");
        
        /// <summary>
        /// Set the visibility of the elements of tags `elementTags' to `value'.
        /// </summary>

        public static unsafe delegate* <ulong*,ulong,int,int*,void> gmshModelMeshSetVisibility; gmshModelMeshSetVisibility = (delegate* <ulong*,ulong,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshSetVisibility");
        
        /// <summary>
        /// Classify ("color") the surface mesh based on the angle threshold `angle'
        /// (in radians), and create new discrete surfaces, curves and points
        /// accordingly. If `boundary' is set, also create discrete curves on the
        /// boundary if the surface is open. If `forReparametrization' is set, create
        /// curves and surfaces that can be reparametrized using a single map. If
        /// `curveAngle' is less than Pi, also force curves to be split according to
        /// `curveAngle'. If `exportDiscrete' is set, clear any built-in CAD kernel
        /// entities and export the discrete entities in the built-in CAD kernel.
        /// </summary>

        public static unsafe delegate* <double,int,int,double,int,int*,void> gmshModelMeshClassifySurfaces; gmshModelMeshClassifySurfaces = (delegate* <double,int,int,double,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshClassifySurfaces");
        
        /// <summary>
        /// Create a geometry for the discrete entities `dimTags' (represented solely
        /// by a mesh, without an underlying CAD description), i.e. create a
        /// parametrization for discrete curves and surfaces, assuming that each can be
        /// parametrized with a single map. If `dimTags' is empty, create a geometry
        /// for all the discrete entities.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int*,void> gmshModelMeshCreateGeometry; gmshModelMeshCreateGeometry = (delegate* <int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshCreateGeometry");
        
        /// <summary>
        /// Create a boundary representation from the mesh if the model does not have
        /// one (e.g. when imported from mesh file formats with no BRep representation
        /// of the underlying model). If `makeSimplyConnected' is set, enforce simply
        /// connected discrete surfaces and volumes. If `exportDiscrete' is set, clear
        /// any built-in CAD kernel entities and export the discrete entities in the
        /// built-in CAD kernel.
        /// </summary>

        public static unsafe delegate* <int,int,int*,void> gmshModelMeshCreateTopology; gmshModelMeshCreateTopology = (delegate* <int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshCreateTopology");
        
        /// <summary>
        /// Add a request to compute a basis representation for homology spaces (if
        /// `type' == "Homology") or cohomology spaces (if `type' == "Cohomology"). The
        /// computation domain is given in a list of physical group tags `domainTags';
        /// if empty, the whole mesh is the domain. The computation subdomain for
        /// relative (co)homology computation is given in a list of physical group tags
        /// `subdomainTags'; if empty, absolute (co)homology is computed. The
        /// dimensions of the (co)homology bases to be computed are given in the list
        /// `dim'; if empty, all bases are computed. Resulting basis representation
        /// (co)chains are stored as physical groups in the mesh. If the request is
        /// added before mesh generation, the computation will be performed at the end
        /// of the meshing pipeline.
        /// </summary>

        public static unsafe delegate* <nint,int*,ulong,int*,ulong,int*,ulong,int*,void> gmshModelMeshAddHomologyRequest; gmshModelMeshAddHomologyRequest = (delegate* <nint,int*,ulong,int*,ulong,int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshAddHomologyRequest");
        
        /// <summary>
        /// Clear all (co)homology computation requests.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshModelMeshClearHomologyRequests; gmshModelMeshClearHomologyRequests = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshClearHomologyRequests");
        
        /// <summary>
        /// Perform the (co)homology computations requested by addHomologyRequest().
        /// </summary>

        public static unsafe delegate* <int*,void> gmshModelMeshComputeHomology; gmshModelMeshComputeHomology = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshComputeHomology");
        
        /// <summary>
        /// Compute a cross field for the current mesh. The function creates 3 views:
        /// the H function, the Theta function and cross directions. Return the tags of
        /// the views.
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,int*,void> gmshModelMeshComputeCrossField; gmshModelMeshComputeCrossField = (delegate* <IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshComputeCrossField");
        
        /// <summary>
        /// Triangulate the points given in the `coord' vector as pairs of u, v
        /// coordinates, and return the node tags (with numbering starting at 1) of the
        /// resulting triangles in `tri'.
        /// </summary>

        public static unsafe delegate* <double*,ulong,IntPtr*,ulong*,int*,void> gmshModelMeshTriangulate; gmshModelMeshTriangulate = (delegate* <double*,ulong,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshTriangulate");
        
        /// <summary>
        /// Tetrahedralize the points given in the `coord' vector as triplets of x, y,
        /// z coordinates, and return the node tags (with numbering starting at 1) of
        /// the resulting tetrahedra in `tetra'.
        /// </summary>

        public static unsafe delegate* <double*,ulong,IntPtr*,ulong*,int*,void> gmshModelMeshTetrahedralize; gmshModelMeshTetrahedralize = (delegate* <double*,ulong,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshTetrahedralize");
        
        /// <summary>
        /// Add a new mesh size field of type `fieldType'. If `tag' is positive, assign
        /// the tag explicitly; otherwise a new tag is assigned automatically. Return
        /// the field tag.
        /// </summary>

        public static unsafe delegate* <nint,int,int*,int> gmshModelMeshFieldAdd; gmshModelMeshFieldAdd = (delegate* <nint,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelMeshFieldAdd");
        
        /// <summary>
        /// Remove the field with tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,int*,void> gmshModelMeshFieldRemove; gmshModelMeshFieldRemove = (delegate* <int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshFieldRemove");
        
        /// <summary>
        /// Get the list of all fields.
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,int*,void> gmshModelMeshFieldList; gmshModelMeshFieldList = (delegate* <IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshFieldList");
        
        /// <summary>
        /// Get the type `fieldType' of the field with tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,IntPtr*,int*,void> gmshModelMeshFieldGetType; gmshModelMeshFieldGetType = (delegate* <int,IntPtr*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshFieldGetType");
        
        /// <summary>
        /// Set the numerical option `option' to value `value' for field `tag'.
        /// </summary>

        public static unsafe delegate* <int,nint,double,int*,void> gmshModelMeshFieldSetNumber; gmshModelMeshFieldSetNumber = (delegate* <int,nint,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshFieldSetNumber");
        
        /// <summary>
        /// Get the value of the numerical option `option' for field `tag'.
        /// </summary>

        public static unsafe delegate* <int,nint,double*,int*,void> gmshModelMeshFieldGetNumber; gmshModelMeshFieldGetNumber = (delegate* <int,nint,double*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshFieldGetNumber");
        
        /// <summary>
        /// Set the string option `option' to value `value' for field `tag'.
        /// </summary>

        public static unsafe delegate* <int,nint,nint,int*,void> gmshModelMeshFieldSetString; gmshModelMeshFieldSetString = (delegate* <int,nint,nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshFieldSetString");
        
        /// <summary>
        /// Get the value of the string option `option' for field `tag'.
        /// </summary>

        public static unsafe delegate* <int,nint,IntPtr*,int*,void> gmshModelMeshFieldGetString; gmshModelMeshFieldGetString = (delegate* <int,nint,IntPtr*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshFieldGetString");
        
        /// <summary>
        /// Set the numerical list option `option' to value `value' for field `tag'.
        /// </summary>

        public static unsafe delegate* <int,nint,double*,ulong,int*,void> gmshModelMeshFieldSetNumbers; gmshModelMeshFieldSetNumbers = (delegate* <int,nint,double*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshFieldSetNumbers");
        
        /// <summary>
        /// Get the value of the numerical list option `option' for field `tag'.
        /// </summary>

        public static unsafe delegate* <int,nint,IntPtr*,ulong*,int*,void> gmshModelMeshFieldGetNumbers; gmshModelMeshFieldGetNumbers = (delegate* <int,nint,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshFieldGetNumbers");
        
        /// <summary>
        /// Set the field `tag' as the background mesh size field.
        /// </summary>

        public static unsafe delegate* <int,int*,void> gmshModelMeshFieldSetAsBackgroundMesh; gmshModelMeshFieldSetAsBackgroundMesh = (delegate* <int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshFieldSetAsBackgroundMesh");
        
        /// <summary>
        /// Set the field `tag' as a boundary layer size field.
        /// </summary>

        public static unsafe delegate* <int,int*,void> gmshModelMeshFieldSetAsBoundaryLayer; gmshModelMeshFieldSetAsBoundaryLayer = (delegate* <int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelMeshFieldSetAsBoundaryLayer");
        
        /// <summary>
        /// Add a geometrical point in the built-in CAD representation, at coordinates
        /// (`x', `y', `z'). If `meshSize' is &gt; 0, add a meshing constraint at that
        /// point. If `tag' is positive, set the tag explicitly; otherwise a new tag is
        /// selected automatically. Return the tag of the point. (Note that the point
        /// will be added in the current model only after `synchronize' is called. This
        /// behavior holds for all the entities added in the geo module.)
        /// </summary>

        public static unsafe delegate* <double,double,double,double,int,int*,int> gmshModelGeoAddPoint; gmshModelGeoAddPoint = (delegate* <double,double,double,double,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddPoint");
        
        /// <summary>
        /// Add a straight line segment in the built-in CAD representation, between the
        /// two points with tags `startTag' and `endTag'. If `tag' is positive, set the
        /// tag explicitly; otherwise a new tag is selected automatically. Return the
        /// tag of the line.
        /// </summary>

        public static unsafe delegate* <int,int,int,int*,int> gmshModelGeoAddLine; gmshModelGeoAddLine = (delegate* <int,int,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddLine");
        
        /// <summary>
        /// Add a circle arc (strictly smaller than Pi) in the built-in CAD
        /// representation, between the two points with tags `startTag' and `endTag',
        /// and with center `centerTag'. If `tag' is positive, set the tag explicitly;
        /// otherwise a new tag is selected automatically. If (`nx', `ny', `nz') != (0,
        /// 0, 0), explicitly set the plane of the circle arc. Return the tag of the
        /// circle arc.
        /// </summary>

        public static unsafe delegate* <int,int,int,int,double,double,double,int*,int> gmshModelGeoAddCircleArc; gmshModelGeoAddCircleArc = (delegate* <int,int,int,int,double,double,double,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddCircleArc");
        
        /// <summary>
        /// Add an ellipse arc (strictly smaller than Pi) in the built-in CAD
        /// representation, between the two points `startTag' and `endTag', and with
        /// center `centerTag' and major axis point `majorTag'. If `tag' is positive,
        /// set the tag explicitly; otherwise a new tag is selected automatically. If
        /// (`nx', `ny', `nz') != (0, 0, 0), explicitly set the plane of the circle
        /// arc. Return the tag of the ellipse arc.
        /// </summary>

        public static unsafe delegate* <int,int,int,int,int,double,double,double,int*,int> gmshModelGeoAddEllipseArc; gmshModelGeoAddEllipseArc = (delegate* <int,int,int,int,int,double,double,double,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddEllipseArc");
        
        /// <summary>
        /// Add a spline (Catmull-Rom) curve in the built-in CAD representation, going
        /// through the points `pointTags'. If `tag' is positive, set the tag
        /// explicitly; otherwise a new tag is selected automatically. Create a
        /// periodic curve if the first and last points are the same. Return the tag of
        /// the spline curve.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int*,int> gmshModelGeoAddSpline; gmshModelGeoAddSpline = (delegate* <int*,ulong,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddSpline");
        
        /// <summary>
        /// Add a cubic b-spline curve in the built-in CAD representation, with
        /// `pointTags' control points. If `tag' is positive, set the tag explicitly;
        /// otherwise a new tag is selected automatically. Creates a periodic curve if
        /// the first and last points are the same. Return the tag of the b-spline
        /// curve.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int*,int> gmshModelGeoAddBSpline; gmshModelGeoAddBSpline = (delegate* <int*,ulong,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddBSpline");
        
        /// <summary>
        /// Add a Bezier curve in the built-in CAD representation, with `pointTags'
        /// control points. If `tag' is positive, set the tag explicitly; otherwise a
        /// new tag is selected automatically.  Return the tag of the Bezier curve.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int*,int> gmshModelGeoAddBezier; gmshModelGeoAddBezier = (delegate* <int*,ulong,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddBezier");
        
        /// <summary>
        /// Add a polyline curve in the built-in CAD representation, going through the
        /// points `pointTags'. If `tag' is positive, set the tag explicitly; otherwise
        /// a new tag is selected automatically. Create a periodic curve if the first
        /// and last points are the same. Return the tag of the polyline curve.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int*,int> gmshModelGeoAddPolyline; gmshModelGeoAddPolyline = (delegate* <int*,ulong,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddPolyline");
        
        /// <summary>
        /// Add a spline (Catmull-Rom) curve in the built-in CAD representation, going
        /// through points sampling the curves in `curveTags'. The density of sampling
        /// points on each curve is governed by `numIntervals'. If `tag' is positive,
        /// set the tag explicitly; otherwise a new tag is selected automatically.
        /// Return the tag of the spline.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int,int*,int> gmshModelGeoAddCompoundSpline; gmshModelGeoAddCompoundSpline = (delegate* <int*,ulong,int,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddCompoundSpline");
        
        /// <summary>
        /// Add a b-spline curve in the built-in CAD representation, with control
        /// points sampling the curves in `curveTags'. The density of sampling points
        /// on each curve is governed by `numIntervals'. If `tag' is positive, set the
        /// tag explicitly; otherwise a new tag is selected automatically. Return the
        /// tag of the b-spline.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int,int*,int> gmshModelGeoAddCompoundBSpline; gmshModelGeoAddCompoundBSpline = (delegate* <int*,ulong,int,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddCompoundBSpline");
        
        /// <summary>
        /// Add a curve loop (a closed wire) in the built-in CAD representation, formed
        /// by the curves `curveTags'. `curveTags' should contain (signed) tags of
        /// model entities of dimension 1 forming a closed loop: a negative tag
        /// signifies that the underlying curve is considered with reversed
        /// orientation. If `tag' is positive, set the tag explicitly; otherwise a new
        /// tag is selected automatically. If `reorient' is set, automatically reorient
        /// the curves if necessary. Return the tag of the curve loop.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int,int*,int> gmshModelGeoAddCurveLoop; gmshModelGeoAddCurveLoop = (delegate* <int*,ulong,int,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddCurveLoop");
        
        /// <summary>
        /// Add curve loops in the built-in CAD representation based on the curves
        /// `curveTags'. Return the `tags' of found curve loops, if any.
        /// </summary>

        public static unsafe delegate* <int*,ulong,IntPtr*,ulong*,int*,void> gmshModelGeoAddCurveLoops; gmshModelGeoAddCurveLoops = (delegate* <int*,ulong,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddCurveLoops");
        
        /// <summary>
        /// Add a plane surface in the built-in CAD representation, defined by one or
        /// more curve loops `wireTags'. The first curve loop defines the exterior
        /// contour; additional curve loop define holes. If `tag' is positive, set the
        /// tag explicitly; otherwise a new tag is selected automatically. Return the
        /// tag of the surface.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int*,int> gmshModelGeoAddPlaneSurface; gmshModelGeoAddPlaneSurface = (delegate* <int*,ulong,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddPlaneSurface");
        
        /// <summary>
        /// Add a surface in the built-in CAD representation, filling the curve loops
        /// in `wireTags' using transfinite interpolation. Currently only a single
        /// curve loop is supported; this curve loop should be composed by 3 or 4
        /// curves only. If `tag' is positive, set the tag explicitly; otherwise a new
        /// tag is selected automatically. Return the tag of the surface.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int,int*,int> gmshModelGeoAddSurfaceFilling; gmshModelGeoAddSurfaceFilling = (delegate* <int*,ulong,int,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddSurfaceFilling");
        
        /// <summary>
        /// Add a surface loop (a closed shell) formed by `surfaceTags' in the built-in
        /// CAD representation.  If `tag' is positive, set the tag explicitly;
        /// otherwise a new tag is selected automatically. Return the tag of the shell.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int*,int> gmshModelGeoAddSurfaceLoop; gmshModelGeoAddSurfaceLoop = (delegate* <int*,ulong,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddSurfaceLoop");
        
        /// <summary>
        /// Add a volume (a region) in the built-in CAD representation, defined by one
        /// or more shells `shellTags'. The first surface loop defines the exterior
        /// boundary; additional surface loop define holes. If `tag' is positive, set
        /// the tag explicitly; otherwise a new tag is selected automatically. Return
        /// the tag of the volume.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int*,int> gmshModelGeoAddVolume; gmshModelGeoAddVolume = (delegate* <int*,ulong,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddVolume");
        
        /// <summary>
        /// Add a `geometry' in the built-in CAD representation. `geometry' can
        /// currently be one of "Sphere" or "PolarSphere" (where `numbers' should
        /// contain the x, y, z coordinates of the center, followed by the radius), or
        /// "Parametric" (where `strings' should contains three expression evaluating
        /// to the x, y and z coordinates. If `tag' is positive, set the tag of the
        /// geometry explicitly; otherwise a new tag is selected automatically. Return
        /// the tag of the geometry.
        /// </summary>

        public static unsafe delegate* <nint,double*,ulong,IntPtr*,ulong,int,int*,int> gmshModelGeoAddGeometry; gmshModelGeoAddGeometry = (delegate* <nint,double*,ulong,IntPtr*,ulong,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddGeometry");
        
        /// <summary>
        /// Add a point in the built-in CAD representation, at coordinates (`x', `y',
        /// `z') on the geometry `geometryTag'. If `meshSize' is &gt; 0, add a meshing
        /// constraint at that point. If `tag' is positive, set the tag explicitly;
        /// otherwise a new tag is selected automatically. Return the tag of the point.
        /// For surface geometries, only the `x' and `y' coordinates are used.
        /// </summary>

        public static unsafe delegate* <int,double,double,double,double,int,int*,int> gmshModelGeoAddPointOnGeometry; gmshModelGeoAddPointOnGeometry = (delegate* <int,double,double,double,double,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddPointOnGeometry");
        
        /// <summary>
        /// Extrude the entities `dimTags' in the built-in CAD representation, using a
        /// translation along (`dx', `dy', `dz'). Return extruded entities in
        /// `outDimTags'. If `numElements' is not empty, also extrude the mesh: the
        /// entries in `numElements' give the number of elements in each layer. If
        /// `height' is not empty, it provides the (cumulative) height of the different
        /// layers, normalized to 1. If `recombine' is set, recombine the mesh in the
        /// layers.
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,double,double,IntPtr*,ulong*,int*,ulong,double*,ulong,int,int*,void> gmshModelGeoExtrude; gmshModelGeoExtrude = (delegate* <int*,ulong,double,double,double,IntPtr*,ulong*,int*,ulong,double*,ulong,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoExtrude");
        
        /// <summary>
        /// Extrude the entities `dimTags' in the built-in CAD representation, using a
        /// rotation of `angle' radians around the axis of revolution defined by the
        /// point (`x', `y', `z') and the direction (`ax', `ay', `az'). The angle
        /// should be strictly smaller than Pi. Return extruded entities in
        /// `outDimTags'. If `numElements' is not empty, also extrude the mesh: the
        /// entries in `numElements' give the number of elements in each layer. If
        /// `height' is not empty, it provides the (cumulative) height of the different
        /// layers, normalized to 1. If `recombine' is set, recombine the mesh in the
        /// layers.
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,double,double,double,double,double,double,IntPtr*,ulong*,int*,ulong,double*,ulong,int,int*,void> gmshModelGeoRevolve; gmshModelGeoRevolve = (delegate* <int*,ulong,double,double,double,double,double,double,double,IntPtr*,ulong*,int*,ulong,double*,ulong,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoRevolve");
        
        /// <summary>
        /// Extrude the entities `dimTags' in the built-in CAD representation, using a
        /// combined translation and rotation of `angle' radians, along (`dx', `dy',
        /// `dz') and around the axis of revolution defined by the point (`x', `y',
        /// `z') and the direction (`ax', `ay', `az'). The angle should be strictly
        /// smaller than Pi. Return extruded entities in `outDimTags'. If `numElements'
        /// is not empty, also extrude the mesh: the entries in `numElements' give the
        /// number of elements in each layer. If `height' is not empty, it provides the
        /// (cumulative) height of the different layers, normalized to 1. If
        /// `recombine' is set, recombine the mesh in the layers.
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,double,double,double,double,double,double,double,double,double,IntPtr*,ulong*,int*,ulong,double*,ulong,int,int*,void> gmshModelGeoTwist; gmshModelGeoTwist = (delegate* <int*,ulong,double,double,double,double,double,double,double,double,double,double,IntPtr*,ulong*,int*,ulong,double*,ulong,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoTwist");
        
        /// <summary>
        /// Extrude the entities `dimTags' in the built-in CAD representation along the
        /// normals of the mesh, creating discrete boundary layer entities. Return
        /// extruded entities in `outDimTags'. The entries in `numElements' give the
        /// number of elements in each layer. If `height' is not empty, it provides the
        /// (cumulative) height of the different layers. If `recombine' is set,
        /// recombine the mesh in the layers. A second boundary layer can be created
        /// from the same entities if `second' is set. If `viewIndex' is &gt;= 0, use the
        /// corresponding view to either specify the normals (if the view contains a
        /// vector field) or scale the normals (if the view is scalar).
        /// </summary>

        public static unsafe delegate* <int*,ulong,IntPtr*,ulong*,int*,ulong,double*,ulong,int,int,int,int*,void> gmshModelGeoExtrudeBoundaryLayer; gmshModelGeoExtrudeBoundaryLayer = (delegate* <int*,ulong,IntPtr*,ulong*,int*,ulong,double*,ulong,int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoExtrudeBoundaryLayer");
        
        /// <summary>
        /// Translate the entities `dimTags' in the built-in CAD representation along
        /// (`dx', `dy', `dz').
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,double,double,int*,void> gmshModelGeoTranslate; gmshModelGeoTranslate = (delegate* <int*,ulong,double,double,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoTranslate");
        
        /// <summary>
        /// Rotate the entities `dimTags' in the built-in CAD representation by `angle'
        /// radians around the axis of revolution defined by the point (`x', `y', `z')
        /// and the direction (`ax', `ay', `az').
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,double,double,double,double,double,double,int*,void> gmshModelGeoRotate; gmshModelGeoRotate = (delegate* <int*,ulong,double,double,double,double,double,double,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoRotate");
        
        /// <summary>
        /// Scale the entities `dimTag' in the built-in CAD representation by factors
        /// `a', `b' and `c' along the three coordinate axes; use (`x', `y', `z') as
        /// the center of the homothetic transformation.
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,double,double,double,double,double,int*,void> gmshModelGeoDilate; gmshModelGeoDilate = (delegate* <int*,ulong,double,double,double,double,double,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoDilate");
        
        /// <summary>
        /// Mirror the entities `dimTag' in the built-in CAD representation, with
        /// respect to the plane of equation `a' * x + `b' * y + `c' * z + `d' = 0.
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,double,double,double,int*,void> gmshModelGeoMirror; gmshModelGeoMirror = (delegate* <int*,ulong,double,double,double,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoMirror");
        
        /// <summary>
        /// Mirror the entities `dimTag' in the built-in CAD representation, with
        /// respect to the plane of equation `a' * x + `b' * y + `c' * z + `d' = 0.
        /// (This is a synonym for `mirror', which will be deprecated in a future
        /// release.)
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,double,double,double,int*,void> gmshModelGeoSymmetrize; gmshModelGeoSymmetrize = (delegate* <int*,ulong,double,double,double,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoSymmetrize");
        
        /// <summary>
        /// Copy the entities `dimTags' in the built-in CAD representation; the new
        /// entities are returned in `outDimTags'.
        /// </summary>

        public static unsafe delegate* <int*,ulong,IntPtr*,ulong*,int*,void> gmshModelGeoCopy; gmshModelGeoCopy = (delegate* <int*,ulong,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoCopy");
        
        /// <summary>
        /// Remove the entities `dimTags' in the built-in CAD representation, provided
        /// that they are not on the boundary of higher-dimensional entities. If
        /// `recursive' is true, remove all the entities on their boundaries, down to
        /// dimension 0.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int*,void> gmshModelGeoRemove; gmshModelGeoRemove = (delegate* <int*,ulong,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoRemove");
        
        /// <summary>
        /// Remove all duplicate entities in the built-in CAD representation (different
        /// entities at the same geometrical location).
        /// </summary>

        public static unsafe delegate* <int*,void> gmshModelGeoRemoveAllDuplicates; gmshModelGeoRemoveAllDuplicates = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoRemoveAllDuplicates");
        
        /// <summary>
        /// Split the curve of tag `tag' in the built-in CAD representation, on the
        /// specified control points `pointTags'. This feature is only available for
        /// lines, splines and b-splines. Return the tag(s) `curveTags' of the newly
        /// created curve(s).
        /// </summary>

        public static unsafe delegate* <int,int*,ulong,IntPtr*,ulong*,int*,void> gmshModelGeoSplitCurve; gmshModelGeoSplitCurve = (delegate* <int,int*,ulong,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoSplitCurve");
        
        /// <summary>
        /// Get the maximum tag of entities of dimension `dim' in the built-in CAD
        /// representation.
        /// </summary>

        public static unsafe delegate* <int,int*,int> gmshModelGeoGetMaxTag; gmshModelGeoGetMaxTag = (delegate* <int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoGetMaxTag");
        
        /// <summary>
        /// Set the maximum tag `maxTag' for entities of dimension `dim' in the built-
        /// in CAD representation.
        /// </summary>

        public static unsafe delegate* <int,int,int*,void> gmshModelGeoSetMaxTag; gmshModelGeoSetMaxTag = (delegate* <int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoSetMaxTag");
        
        /// <summary>
        /// Add a physical group of dimension `dim', grouping the entities with tags
        /// `tags' in the built-in CAD representation. Return the tag of the physical
        /// group, equal to `tag' if `tag' is positive, or a new tag if `tag' 
        /// &lt;
        /// 0. Set
        /// the name of the physical group if `name' is not empty.
        /// </summary>

        public static unsafe delegate* <int,int*,ulong,int,nint,int*,int> gmshModelGeoAddPhysicalGroup; gmshModelGeoAddPhysicalGroup = (delegate* <int,int*,ulong,int,nint,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelGeoAddPhysicalGroup");
        
        /// <summary>
        /// Remove the physical groups `dimTags' from the built-in CAD representation.
        /// If `dimTags' is empty, remove all groups.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int*,void> gmshModelGeoRemovePhysicalGroups; gmshModelGeoRemovePhysicalGroups = (delegate* <int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoRemovePhysicalGroups");
        
        /// <summary>
        /// Synchronize the built-in CAD representation with the current Gmsh model.
        /// This can be called at any time, but since it involves a non trivial amount
        /// of processing, the number of synchronization points should normally be
        /// minimized. Without synchronization the entities in the built-in CAD
        /// representation are not available to any function outside of the built-in
        /// CAD kernel functions.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshModelGeoSynchronize; gmshModelGeoSynchronize = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoSynchronize");
        
        /// <summary>
        /// Set a mesh size constraint on the entities `dimTags' in the built-in CAD
        /// kernel representation. Currently only entities of dimension 0 (points) are
        /// handled.
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,int*,void> gmshModelGeoMeshSetSize; gmshModelGeoMeshSetSize = (delegate* <int*,ulong,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoMeshSetSize");
        
        /// <summary>
        /// Set a transfinite meshing constraint on the curve `tag' in the built-in CAD
        /// kernel representation, with `numNodes' nodes distributed according to
        /// `meshType' and `coef'. Currently supported types are "Progression"
        /// (geometrical progression with power `coef') and "Bump" (refinement toward
        /// both extremities of the curve).
        /// </summary>

        public static unsafe delegate* <int,int,nint,double,int*,void> gmshModelGeoMeshSetTransfiniteCurve; gmshModelGeoMeshSetTransfiniteCurve = (delegate* <int,int,nint,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoMeshSetTransfiniteCurve");
        
        /// <summary>
        /// Set a transfinite meshing constraint on the surface `tag' in the built-in
        /// CAD kernel representation. `arrangement' describes the arrangement of the
        /// triangles when the surface is not flagged as recombined: currently
        /// supported values are "Left", "Right", "AlternateLeft" and "AlternateRight".
        /// `cornerTags' can be used to specify the (3 or 4) corners of the transfinite
        /// interpolation explicitly; specifying the corners explicitly is mandatory if
        /// the surface has more that 3 or 4 points on its boundary.
        /// </summary>

        public static unsafe delegate* <int,nint,int*,ulong,int*,void> gmshModelGeoMeshSetTransfiniteSurface; gmshModelGeoMeshSetTransfiniteSurface = (delegate* <int,nint,int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoMeshSetTransfiniteSurface");
        
        /// <summary>
        /// Set a transfinite meshing constraint on the surface `tag' in the built-in
        /// CAD kernel representation. `cornerTags' can be used to specify the (6 or 8)
        /// corners of the transfinite interpolation explicitly.
        /// </summary>

        public static unsafe delegate* <int,int*,ulong,int*,void> gmshModelGeoMeshSetTransfiniteVolume; gmshModelGeoMeshSetTransfiniteVolume = (delegate* <int,int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoMeshSetTransfiniteVolume");
        
        /// <summary>
        /// Set a recombination meshing constraint on the entity of dimension `dim' and
        /// tag `tag' in the built-in CAD kernel representation. Currently only
        /// entities of dimension 2 (to recombine triangles into quadrangles) are
        /// supported; `angle' specifies the threshold angle for the simple
        /// recombination algorithm.
        /// </summary>

        public static unsafe delegate* <int,int,double,int*,void> gmshModelGeoMeshSetRecombine; gmshModelGeoMeshSetRecombine = (delegate* <int,int,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoMeshSetRecombine");
        
        /// <summary>
        /// Set a smoothing meshing constraint on the entity of dimension `dim' and tag
        /// `tag' in the built-in CAD kernel representation. `val' iterations of a
        /// Laplace smoother are applied.
        /// </summary>

        public static unsafe delegate* <int,int,int,int*,void> gmshModelGeoMeshSetSmoothing; gmshModelGeoMeshSetSmoothing = (delegate* <int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoMeshSetSmoothing");
        
        /// <summary>
        /// Set a reverse meshing constraint on the entity of dimension `dim' and tag
        /// `tag' in the built-in CAD kernel representation. If `val' is true, the mesh
        /// orientation will be reversed with respect to the natural mesh orientation
        /// (i.e. the orientation consistent with the orientation of the geometry). If
        /// `val' is false, the mesh is left as-is.
        /// </summary>

        public static unsafe delegate* <int,int,int,int*,void> gmshModelGeoMeshSetReverse; gmshModelGeoMeshSetReverse = (delegate* <int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoMeshSetReverse");
        
        /// <summary>
        /// Set the meshing algorithm on the entity of dimension `dim' and tag `tag' in
        /// the built-in CAD kernel representation. Currently only supported for `dim'
        /// == 2.
        /// </summary>

        public static unsafe delegate* <int,int,int,int*,void> gmshModelGeoMeshSetAlgorithm; gmshModelGeoMeshSetAlgorithm = (delegate* <int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoMeshSetAlgorithm");
        
        /// <summary>
        /// Force the mesh size to be extended from the boundary, or not, for the
        /// entity of dimension `dim' and tag `tag' in the built-in CAD kernel
        /// representation. Currently only supported for `dim' == 2.
        /// </summary>

        public static unsafe delegate* <int,int,int,int*,void> gmshModelGeoMeshSetSizeFromBoundary; gmshModelGeoMeshSetSizeFromBoundary = (delegate* <int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelGeoMeshSetSizeFromBoundary");
        
        /// <summary>
        /// Add a geometrical point in the OpenCASCADE CAD representation, at
        /// coordinates (`x', `y', `z'). If `meshSize' is &gt; 0, add a meshing constraint
        /// at that point. If `tag' is positive, set the tag explicitly; otherwise a
        /// new tag is selected automatically. Return the tag of the point. (Note that
        /// the point will be added in the current model only after `synchronize' is
        /// called. This behavior holds for all the entities added in the occ module.)
        /// </summary>

        public static unsafe delegate* <double,double,double,double,int,int*,int> gmshModelOccAddPoint; gmshModelOccAddPoint = (delegate* <double,double,double,double,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddPoint");
        
        /// <summary>
        /// Add a straight line segment in the OpenCASCADE CAD representation, between
        /// the two points with tags `startTag' and `endTag'. If `tag' is positive, set
        /// the tag explicitly; otherwise a new tag is selected automatically. Return
        /// the tag of the line.
        /// </summary>

        public static unsafe delegate* <int,int,int,int*,int> gmshModelOccAddLine; gmshModelOccAddLine = (delegate* <int,int,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddLine");
        
        /// <summary>
        /// Add a circle arc in the OpenCASCADE CAD representation, between the two
        /// points with tags `startTag' and `endTag', with center `centerTag'. If `tag'
        /// is positive, set the tag explicitly; otherwise a new tag is selected
        /// automatically. Return the tag of the circle arc.
        /// </summary>

        public static unsafe delegate* <int,int,int,int,int*,int> gmshModelOccAddCircleArc; gmshModelOccAddCircleArc = (delegate* <int,int,int,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddCircleArc");
        
        /// <summary>
        /// Add a circle of center (`x', `y', `z') and radius `r' in the OpenCASCADE
        /// CAD representation. If `tag' is positive, set the tag explicitly; otherwise
        /// a new tag is selected automatically. If `angle1' and `angle2' are
        /// specified, create a circle arc between the two angles. If a vector `zAxis'
        /// of size 3 is provided, use it as the normal to the circle plane (z-axis).
        /// If a vector `xAxis' of size 3 is provided in addition to `zAxis', use it to
        /// define the x-axis. Return the tag of the circle.
        /// </summary>

        public static unsafe delegate* <double,double,double,double,int,double,double,double*,ulong,double*,ulong,int*,int> gmshModelOccAddCircle; gmshModelOccAddCircle = (delegate* <double,double,double,double,int,double,double,double*,ulong,double*,ulong,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddCircle");
        
        /// <summary>
        /// Add an ellipse arc in the OpenCASCADE CAD representation, between the two
        /// points `startTag' and `endTag', and with center `centerTag' and major axis
        /// point `majorTag'. If `tag' is positive, set the tag explicitly; otherwise a
        /// new tag is selected automatically. Return the tag of the ellipse arc. Note
        /// that OpenCASCADE does not allow creating ellipse arcs with the major radius
        /// smaller than the minor radius.
        /// </summary>

        public static unsafe delegate* <int,int,int,int,int,int*,int> gmshModelOccAddEllipseArc; gmshModelOccAddEllipseArc = (delegate* <int,int,int,int,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddEllipseArc");
        
        /// <summary>
        /// Add an ellipse of center (`x', `y', `z') and radii `r1' and `r2' (with `r1'
        /// &gt;= `r2') along the x- and y-axes, respectively, in the OpenCASCADE CAD
        /// representation. If `tag' is positive, set the tag explicitly; otherwise a
        /// new tag is selected automatically. If `angle1' and `angle2' are specified,
        /// create an ellipse arc between the two angles. If a vector `zAxis' of size 3
        /// is provided, use it as the normal to the ellipse plane (z-axis). If a
        /// vector `xAxis' of size 3 is provided in addition to `zAxis', use it to
        /// define the x-axis. Return the tag of the ellipse.
        /// </summary>

        public static unsafe delegate* <double,double,double,double,double,int,double,double,double*,ulong,double*,ulong,int*,int> gmshModelOccAddEllipse; gmshModelOccAddEllipse = (delegate* <double,double,double,double,double,int,double,double,double*,ulong,double*,ulong,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddEllipse");
        
        /// <summary>
        /// Add a spline (C2 b-spline) curve in the OpenCASCADE CAD representation,
        /// going through the points `pointTags'. If `tag' is positive, set the tag
        /// explicitly; otherwise a new tag is selected automatically. Create a
        /// periodic curve if the first and last points are the same. Return the tag of
        /// the spline curve.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int*,int> gmshModelOccAddSpline; gmshModelOccAddSpline = (delegate* <int*,ulong,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddSpline");
        
        /// <summary>
        /// Add a b-spline curve of degree `degree' in the OpenCASCADE CAD
        /// representation, with `pointTags' control points. If `weights', `knots' or
        /// `multiplicities' are not provided, default parameters are computed
        /// automatically. If `tag' is positive, set the tag explicitly; otherwise a
        /// new tag is selected automatically. Create a periodic curve if the first and
        /// last points are the same. Return the tag of the b-spline curve.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int,double*,ulong,double*,ulong,int*,ulong,int*,int> gmshModelOccAddBSpline; gmshModelOccAddBSpline = (delegate* <int*,ulong,int,int,double*,ulong,double*,ulong,int*,ulong,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddBSpline");
        
        /// <summary>
        /// Add a Bezier curve in the OpenCASCADE CAD representation, with `pointTags'
        /// control points. If `tag' is positive, set the tag explicitly; otherwise a
        /// new tag is selected automatically. Return the tag of the Bezier curve.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int*,int> gmshModelOccAddBezier; gmshModelOccAddBezier = (delegate* <int*,ulong,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddBezier");
        
        /// <summary>
        /// Add a wire (open or closed) in the OpenCASCADE CAD representation, formed
        /// by the curves `curveTags'. Note that an OpenCASCADE wire can be made of
        /// curves that share geometrically identical (but topologically different)
        /// points. If `tag' is positive, set the tag explicitly; otherwise a new tag
        /// is selected automatically. Return the tag of the wire.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int,int*,int> gmshModelOccAddWire; gmshModelOccAddWire = (delegate* <int*,ulong,int,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddWire");
        
        /// <summary>
        /// Add a curve loop (a closed wire) in the OpenCASCADE CAD representation,
        /// formed by the curves `curveTags'. `curveTags' should contain tags of curves
        /// forming a closed loop. Negative tags can be specified for compatibility
        /// with the built-in kernel, but are simply ignored: the wire is oriented
        /// according to the orientation of its first curve. Note that an OpenCASCADE
        /// curve loop can be made of curves that share geometrically identical (but
        /// topologically different) points. If `tag' is positive, set the tag
        /// explicitly; otherwise a new tag is selected automatically. Return the tag
        /// of the curve loop.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int*,int> gmshModelOccAddCurveLoop; gmshModelOccAddCurveLoop = (delegate* <int*,ulong,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddCurveLoop");
        
        /// <summary>
        /// Add a rectangle in the OpenCASCADE CAD representation, with lower left
        /// corner at (`x', `y', `z') and upper right corner at (`x' + `dx', `y' +
        /// `dy', `z'). If `tag' is positive, set the tag explicitly; otherwise a new
        /// tag is selected automatically. Round the corners if `roundedRadius' is
        /// nonzero. Return the tag of the rectangle.
        /// </summary>

        public static unsafe delegate* <double,double,double,double,double,int,double,int*,int> gmshModelOccAddRectangle; gmshModelOccAddRectangle = (delegate* <double,double,double,double,double,int,double,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddRectangle");
        
        /// <summary>
        /// Add a disk in the OpenCASCADE CAD representation, with center (`xc', `yc',
        /// `zc') and radius `rx' along the x-axis and `ry' along the y-axis (`rx' &gt;=
        /// `ry'). If `tag' is positive, set the tag explicitly; otherwise a new tag is
        /// selected automatically. If a vector `zAxis' of size 3 is provided, use it
        /// as the normal to the disk (z-axis). If a vector `xAxis' of size 3 is
        /// provided in addition to `zAxis', use it to define the x-axis. Return the
        /// tag of the disk.
        /// </summary>

        public static unsafe delegate* <double,double,double,double,double,int,double*,ulong,double*,ulong,int*,int> gmshModelOccAddDisk; gmshModelOccAddDisk = (delegate* <double,double,double,double,double,int,double*,ulong,double*,ulong,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddDisk");
        
        /// <summary>
        /// Add a plane surface in the OpenCASCADE CAD representation, defined by one
        /// or more curve loops (or closed wires) `wireTags'. The first curve loop
        /// defines the exterior contour; additional curve loop define holes. If `tag'
        /// is positive, set the tag explicitly; otherwise a new tag is selected
        /// automatically. Return the tag of the surface.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int*,int> gmshModelOccAddPlaneSurface; gmshModelOccAddPlaneSurface = (delegate* <int*,ulong,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddPlaneSurface");
        
        /// <summary>
        /// Add a surface in the OpenCASCADE CAD representation, filling the curve loop
        /// `wireTag'. If `tag' is positive, set the tag explicitly; otherwise a new
        /// tag is selected automatically. Return the tag of the surface. If
        /// `pointTags' are provided, force the surface to pass through the given
        /// points. The other optional arguments are `degree' (the degree of the energy
        /// criterion to minimize for computing the deformation of the surface),
        /// `numPointsOnCurves' (the average number of points for discretisation of the
        /// bounding curves), `numIter' (the maximum number of iterations of the
        /// optimization process), `anisotropic' (improve performance when the ratio of
        /// the length along the two parametric coordinates of the surface is high),
        /// `tol2d' (tolerance to the constraints in the parametric plane of the
        /// surface), `tol3d' (the maximum distance allowed between the support surface
        /// and the constraints), `tolAng' (the maximum angle allowed between the
        /// normal of the surface and the constraints), `tolCurv' (the maximum
        /// difference of curvature allowed between the surface and the constraint),
        /// `maxDegree' (the highest degree which the polynomial defining the filling
        /// surface can have) and, `maxSegments' (the largest number of segments which
        /// the filling surface can have).
        /// </summary>

        public static unsafe delegate* <int,int,int*,ulong,int,int,int,int,double,double,double,double,int,int,int*,int> gmshModelOccAddSurfaceFilling; gmshModelOccAddSurfaceFilling = (delegate* <int,int,int*,ulong,int,int,int,int,double,double,double,double,int,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddSurfaceFilling");
        
        /// <summary>
        /// Add a BSpline surface in the OpenCASCADE CAD representation, filling the
        /// curve loop `wireTag'. The curve loop should be made of 2, 3 or 4 curves.
        /// The optional `type' argument specifies the type of filling: "Stretch"
        /// creates the flattest patch, "Curved" (the default) creates the most rounded
        /// patch, and "Coons" creates a rounded patch with less depth than "Curved".
        /// If `tag' is positive, set the tag explicitly; otherwise a new tag is
        /// selected automatically. Return the tag of the surface.
        /// </summary>

        public static unsafe delegate* <int,int,nint,int*,int> gmshModelOccAddBSplineFilling; gmshModelOccAddBSplineFilling = (delegate* <int,int,nint,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddBSplineFilling");
        
        /// <summary>
        /// Add a Bezier surface in the OpenCASCADE CAD representation, filling the
        /// curve loop `wireTag'. The curve loop should be made of 2, 3 or 4 Bezier
        /// curves. The optional `type' argument specifies the type of filling:
        /// "Stretch" creates the flattest patch, "Curved" (the default) creates the
        /// most rounded patch, and "Coons" creates a rounded patch with less depth
        /// than "Curved". If `tag' is positive, set the tag explicitly; otherwise a
        /// new tag is selected automatically. Return the tag of the surface.
        /// </summary>

        public static unsafe delegate* <int,int,nint,int*,int> gmshModelOccAddBezierFilling; gmshModelOccAddBezierFilling = (delegate* <int,int,nint,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddBezierFilling");
        
        /// <summary>
        /// Add a b-spline surface of degree `degreeU' x `degreeV' in the OpenCASCADE
        /// CAD representation, with `pointTags' control points given as a single
        /// vector [Pu1v1, ... Pu`numPointsU'v1, Pu1v2, ...]. If `weights', `knotsU',
        /// `knotsV', `multiplicitiesU' or `multiplicitiesV' are not provided, default
        /// parameters are computed automatically. If `tag' is positive, set the tag
        /// explicitly; otherwise a new tag is selected automatically. If `wireTags' is
        /// provided, trim the b-spline patch using the provided wires: the first wire
        /// defines the external contour, the others define holes. If `wire3D' is set,
        /// consider wire curves as 3D curves and project them on the b-spline surface;
        /// otherwise consider the wire curves as defined in the parametric space of
        /// the surface. Return the tag of the b-spline surface.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int,int,int,double*,ulong,double*,ulong,double*,ulong,int*,ulong,int*,ulong,int*,ulong,int,int*,int> gmshModelOccAddBSplineSurface; gmshModelOccAddBSplineSurface = (delegate* <int*,ulong,int,int,int,int,double*,ulong,double*,ulong,double*,ulong,int*,ulong,int*,ulong,int*,ulong,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddBSplineSurface");
        
        /// <summary>
        /// Add a Bezier surface in the OpenCASCADE CAD representation, with
        /// `pointTags' control points given as a single vector [Pu1v1, ...
        /// Pu`numPointsU'v1, Pu1v2, ...]. If `tag' is positive, set the tag
        /// explicitly; otherwise a new tag is selected automatically. If `wireTags' is
        /// provided, trim the Bezier patch using the provided wires: the first wire
        /// defines the external contour, the others define holes. If `wire3D' is set,
        /// consider wire curves as 3D curves and project them on the Bezier surface;
        /// otherwise consider the wire curves as defined in the parametric space of
        /// the surface. Return the tag of the Bezier surface.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int,int*,ulong,int,int*,int> gmshModelOccAddBezierSurface; gmshModelOccAddBezierSurface = (delegate* <int*,ulong,int,int,int*,ulong,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddBezierSurface");
        
        /// <summary>
        /// Trim the surface `surfaceTag' with the wires `wireTags', replacing any
        /// existing trimming curves. The first wire defines the external contour, the
        /// others define holes. If `wire3D' is set, consider wire curves as 3D curves
        /// and project them on the surface; otherwise consider the wire curves as
        /// defined in the parametric space of the surface. If `tag' is positive, set
        /// the tag explicitly; otherwise a new tag is selected automatically. Return
        /// the tag of the trimmed surface.
        /// </summary>

        public static unsafe delegate* <int,int*,ulong,int,int,int*,int> gmshModelOccAddTrimmedSurface; gmshModelOccAddTrimmedSurface = (delegate* <int,int*,ulong,int,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddTrimmedSurface");
        
        /// <summary>
        /// Add a surface loop (a closed shell) in the OpenCASCADE CAD representation,
        /// formed by `surfaceTags'.  If `tag' is positive, set the tag explicitly;
        /// otherwise a new tag is selected automatically. Return the tag of the
        /// surface loop. Setting `sewing' allows one to build a shell made of surfaces
        /// that share geometrically identical (but topologically different) curves.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int,int*,int> gmshModelOccAddSurfaceLoop; gmshModelOccAddSurfaceLoop = (delegate* <int*,ulong,int,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddSurfaceLoop");
        
        /// <summary>
        /// Add a volume (a region) in the OpenCASCADE CAD representation, defined by
        /// one or more surface loops `shellTags'. The first surface loop defines the
        /// exterior boundary; additional surface loop define holes. If `tag' is
        /// positive, set the tag explicitly; otherwise a new tag is selected
        /// automatically. Return the tag of the volume.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int*,int> gmshModelOccAddVolume; gmshModelOccAddVolume = (delegate* <int*,ulong,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddVolume");
        
        /// <summary>
        /// Add a sphere of center (`xc', `yc', `zc') and radius `r' in the OpenCASCADE
        /// CAD representation. The optional `angle1' and `angle2' arguments define the
        /// polar angle opening (from -Pi/2 to Pi/2). The optional `angle3' argument
        /// defines the azimuthal opening (from 0 to 2*Pi). If `tag' is positive, set
        /// the tag explicitly; otherwise a new tag is selected automatically. Return
        /// the tag of the sphere.
        /// </summary>

        public static unsafe delegate* <double,double,double,double,int,double,double,double,int*,int> gmshModelOccAddSphere; gmshModelOccAddSphere = (delegate* <double,double,double,double,int,double,double,double,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddSphere");
        
        /// <summary>
        /// Add a parallelepipedic box in the OpenCASCADE CAD representation, defined
        /// by a point (`x', `y', `z') and the extents along the x-, y- and z-axes. If
        /// `tag' is positive, set the tag explicitly; otherwise a new tag is selected
        /// automatically. Return the tag of the box.
        /// </summary>

        public static unsafe delegate* <double,double,double,double,double,double,int,int*,int> gmshModelOccAddBox; gmshModelOccAddBox = (delegate* <double,double,double,double,double,double,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddBox");
        
        /// <summary>
        /// Add a cylinder in the OpenCASCADE CAD representation, defined by the center
        /// (`x', `y', `z') of its first circular face, the 3 components (`dx', `dy',
        /// `dz') of the vector defining its axis and its radius `r'. The optional
        /// `angle' argument defines the angular opening (from 0 to 2*Pi). If `tag' is
        /// positive, set the tag explicitly; otherwise a new tag is selected
        /// automatically. Return the tag of the cylinder.
        /// </summary>

        public static unsafe delegate* <double,double,double,double,double,double,double,int,double,int*,int> gmshModelOccAddCylinder; gmshModelOccAddCylinder = (delegate* <double,double,double,double,double,double,double,int,double,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddCylinder");
        
        /// <summary>
        /// Add a cone in the OpenCASCADE CAD representation, defined by the center
        /// (`x', `y', `z') of its first circular face, the 3 components of the vector
        /// (`dx', `dy', `dz') defining its axis and the two radii `r1' and `r2' of the
        /// faces (these radii can be zero). If `tag' is positive, set the tag
        /// explicitly; otherwise a new tag is selected automatically. `angle' defines
        /// the optional angular opening (from 0 to 2*Pi). Return the tag of the cone.
        /// </summary>

        public static unsafe delegate* <double,double,double,double,double,double,double,double,int,double,int*,int> gmshModelOccAddCone; gmshModelOccAddCone = (delegate* <double,double,double,double,double,double,double,double,int,double,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddCone");
        
        /// <summary>
        /// Add a right angular wedge in the OpenCASCADE CAD representation, defined by
        /// the right-angle point (`x', `y', `z') and the 3 extends along the x-, y-
        /// and z-axes (`dx', `dy', `dz'). If `tag' is positive, set the tag
        /// explicitly; otherwise a new tag is selected automatically. The optional
        /// argument `ltx' defines the top extent along the x-axis. If a vector `zAxis'
        /// of size 3 is provided, use it to define the z-axis. Return the tag of the
        /// wedge.
        /// </summary>

        public static unsafe delegate* <double,double,double,double,double,double,int,double,double*,ulong,int*,int> gmshModelOccAddWedge; gmshModelOccAddWedge = (delegate* <double,double,double,double,double,double,int,double,double*,ulong,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddWedge");
        
        /// <summary>
        /// Add a torus in the OpenCASCADE CAD representation, defined by its center
        /// (`x', `y', `z') and its 2 radii `r' and `r2'. If `tag' is positive, set the
        /// tag explicitly; otherwise a new tag is selected automatically. The optional
        /// argument `angle' defines the angular opening (from 0 to 2*Pi). If a vector
        /// `zAxis' of size 3 is provided, use it to define the z-axis. Return the tag
        /// of the torus.
        /// </summary>

        public static unsafe delegate* <double,double,double,double,double,int,double,double*,ulong,int*,int> gmshModelOccAddTorus; gmshModelOccAddTorus = (delegate* <double,double,double,double,double,int,double,double*,ulong,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccAddTorus");
        
        /// <summary>
        /// Add a volume (if the optional argument `makeSolid' is set) or surfaces in
        /// the OpenCASCADE CAD representation, defined through the open or closed
        /// wires `wireTags'. If `tag' is positive, set the tag explicitly; otherwise a
        /// new tag is selected automatically. The new entities are returned in
        /// `outDimTags'. If the optional argument `makeRuled' is set, the surfaces
        /// created on the boundary are forced to be ruled surfaces. If `maxDegree' is
        /// positive, set the maximal degree of resulting surface.
        /// </summary>

        public static unsafe delegate* <int*,ulong,IntPtr*,ulong*,int,int,int,int,int*,void> gmshModelOccAddThruSections; gmshModelOccAddThruSections = (delegate* <int*,ulong,IntPtr*,ulong*,int,int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccAddThruSections");
        
        /// <summary>
        /// Add a hollowed volume in the OpenCASCADE CAD representation, built from an
        /// initial volume `volumeTag' and a set of faces from this volume
        /// `excludeSurfaceTags', which are to be removed. The remaining faces of the
        /// volume become the walls of the hollowed solid, with thickness `offset'. If
        /// `tag' is positive, set the tag explicitly; otherwise a new tag is selected
        /// automatically.
        /// </summary>

        public static unsafe delegate* <int,int*,ulong,double,IntPtr*,ulong*,int,int*,void> gmshModelOccAddThickSolid; gmshModelOccAddThickSolid = (delegate* <int,int*,ulong,double,IntPtr*,ulong*,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccAddThickSolid");
        
        /// <summary>
        /// Extrude the entities `dimTags' in the OpenCASCADE CAD representation, using
        /// a translation along (`dx', `dy', `dz'). Return extruded entities in
        /// `outDimTags'. If `numElements' is not empty, also extrude the mesh: the
        /// entries in `numElements' give the number of elements in each layer. If
        /// `height' is not empty, it provides the (cumulative) height of the different
        /// layers, normalized to 1. If `recombine' is set, recombine the mesh in the
        /// layers.
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,double,double,IntPtr*,ulong*,int*,ulong,double*,ulong,int,int*,void> gmshModelOccExtrude; gmshModelOccExtrude = (delegate* <int*,ulong,double,double,double,IntPtr*,ulong*,int*,ulong,double*,ulong,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccExtrude");
        
        /// <summary>
        /// Extrude the entities `dimTags' in the OpenCASCADE CAD representation, using
        /// a rotation of `angle' radians around the axis of revolution defined by the
        /// point (`x', `y', `z') and the direction (`ax', `ay', `az'). Return extruded
        /// entities in `outDimTags'. If `numElements' is not empty, also extrude the
        /// mesh: the entries in `numElements' give the number of elements in each
        /// layer. If `height' is not empty, it provides the (cumulative) height of the
        /// different layers, normalized to 1. When the mesh is extruded the angle
        /// should be strictly smaller than 2*Pi. If `recombine' is set, recombine the
        /// mesh in the layers.
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,double,double,double,double,double,double,IntPtr*,ulong*,int*,ulong,double*,ulong,int,int*,void> gmshModelOccRevolve; gmshModelOccRevolve = (delegate* <int*,ulong,double,double,double,double,double,double,double,IntPtr*,ulong*,int*,ulong,double*,ulong,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccRevolve");
        
        /// <summary>
        /// Add a pipe in the OpenCASCADE CAD representation, by extruding the entities
        /// `dimTags' along the wire `wireTag'. The type of sweep can be specified with
        /// `trihedron' (possible values: "DiscreteTrihedron", "CorrectedFrenet",
        /// "Fixed", "Frenet", "ConstantNormal", "Darboux", "GuideAC", "GuidePlan",
        /// "GuideACWithContact", "GuidePlanWithContact"). If `trihedron' is not
        /// provided, "DiscreteTrihedron" is assumed. Return the pipe in `outDimTags'.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,IntPtr*,ulong*,nint,int*,void> gmshModelOccAddPipe; gmshModelOccAddPipe = (delegate* <int*,ulong,int,IntPtr*,ulong*,nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccAddPipe");
        
        /// <summary>
        /// Fillet the volumes `volumeTags' on the curves `curveTags' with radii
        /// `radii'. The `radii' vector can either contain a single radius, as many
        /// radii as `curveTags', or twice as many as `curveTags' (in which case
        /// different radii are provided for the begin and end points of the curves).
        /// Return the filleted entities in `outDimTags'. Remove the original volume if
        /// `removeVolume' is set.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int*,ulong,double*,ulong,IntPtr*,ulong*,int,int*,void> gmshModelOccFillet; gmshModelOccFillet = (delegate* <int*,ulong,int*,ulong,double*,ulong,IntPtr*,ulong*,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccFillet");
        
        /// <summary>
        /// Chamfer the volumes `volumeTags' on the curves `curveTags' with distances
        /// `distances' measured on surfaces `surfaceTags'. The `distances' vector can
        /// either contain a single distance, as many distances as `curveTags' and
        /// `surfaceTags', or twice as many as `curveTags' and `surfaceTags' (in which
        /// case the first in each pair is measured on the corresponding surface in
        /// `surfaceTags', the other on the other adjacent surface). Return the
        /// chamfered entities in `outDimTags'. Remove the original volume if
        /// `removeVolume' is set.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int*,ulong,int*,ulong,double*,ulong,IntPtr*,ulong*,int,int*,void> gmshModelOccChamfer; gmshModelOccChamfer = (delegate* <int*,ulong,int*,ulong,int*,ulong,double*,ulong,IntPtr*,ulong*,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccChamfer");
        
        /// <summary>
        /// Compute the boolean union (the fusion) of the entities `objectDimTags' and
        /// `toolDimTags' in the OpenCASCADE CAD representation. Return the resulting
        /// entities in `outDimTags'. If `tag' is positive, try to set the tag
        /// explicitly (only valid if the boolean operation results in a single
        /// entity). Remove the object if `removeObject' is set. Remove the tool if
        /// `removeTool' is set.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int*,ulong,IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,int,int,int,int*,void> gmshModelOccFuse; gmshModelOccFuse = (delegate* <int*,ulong,int*,ulong,IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccFuse");
        
        /// <summary>
        /// Compute the boolean intersection (the common parts) of the entities
        /// `objectDimTags' and `toolDimTags' in the OpenCASCADE CAD representation.
        /// Return the resulting entities in `outDimTags'. If `tag' is positive, try to
        /// set the tag explicitly (only valid if the boolean operation results in a
        /// single entity). Remove the object if `removeObject' is set. Remove the tool
        /// if `removeTool' is set.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int*,ulong,IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,int,int,int,int*,void> gmshModelOccIntersect; gmshModelOccIntersect = (delegate* <int*,ulong,int*,ulong,IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccIntersect");
        
        /// <summary>
        /// Compute the boolean difference between the entities `objectDimTags' and
        /// `toolDimTags' in the OpenCASCADE CAD representation. Return the resulting
        /// entities in `outDimTags'. If `tag' is positive, try to set the tag
        /// explicitly (only valid if the boolean operation results in a single
        /// entity). Remove the object if `removeObject' is set. Remove the tool if
        /// `removeTool' is set.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int*,ulong,IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,int,int,int,int*,void> gmshModelOccCut; gmshModelOccCut = (delegate* <int*,ulong,int*,ulong,IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccCut");
        
        /// <summary>
        /// Compute the boolean fragments (general fuse) resulting from the
        /// intersection of the entities `objectDimTags' and `toolDimTags' in the
        /// OpenCASCADE CAD representation, making all iterfaces conformal. When
        /// applied to entities of different dimensions, the lower dimensional entities
        /// will be automatically embedded in the higher dimensional entities if they
        /// are not on their boundary. Return the resulting entities in `outDimTags'.
        /// If `tag' is positive, try to set the tag explicitly (only valid if the
        /// boolean operation results in a single entity). Remove the object if
        /// `removeObject' is set. Remove the tool if `removeTool' is set.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int*,ulong,IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,int,int,int,int*,void> gmshModelOccFragment; gmshModelOccFragment = (delegate* <int*,ulong,int*,ulong,IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccFragment");
        
        /// <summary>
        /// Translate the entities `dimTags' in the OpenCASCADE CAD representation
        /// along (`dx', `dy', `dz').
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,double,double,int*,void> gmshModelOccTranslate; gmshModelOccTranslate = (delegate* <int*,ulong,double,double,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccTranslate");
        
        /// <summary>
        /// Rotate the entities `dimTags' in the OpenCASCADE CAD representation by
        /// `angle' radians around the axis of revolution defined by the point (`x',
        /// `y', `z') and the direction (`ax', `ay', `az').
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,double,double,double,double,double,double,int*,void> gmshModelOccRotate; gmshModelOccRotate = (delegate* <int*,ulong,double,double,double,double,double,double,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccRotate");
        
        /// <summary>
        /// Scale the entities `dimTags' in the OpenCASCADE CAD representation by
        /// factors `a', `b' and `c' along the three coordinate axes; use (`x', `y',
        /// `z') as the center of the homothetic transformation.
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,double,double,double,double,double,int*,void> gmshModelOccDilate; gmshModelOccDilate = (delegate* <int*,ulong,double,double,double,double,double,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccDilate");
        
        /// <summary>
        /// Mirror the entities `dimTags' in the OpenCASCADE CAD representation, with
        /// respect to the plane of equation `a' * x + `b' * y + `c' * z + `d' = 0.
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,double,double,double,int*,void> gmshModelOccMirror; gmshModelOccMirror = (delegate* <int*,ulong,double,double,double,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccMirror");
        
        /// <summary>
        /// Mirror the entities `dimTags' in the OpenCASCADE CAD representation, with
        /// respect to the plane of equation `a' * x + `b' * y + `c' * z + `d' = 0.
        /// (This is a deprecated synonym for `mirror'.)
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,double,double,double,int*,void> gmshModelOccSymmetrize; gmshModelOccSymmetrize = (delegate* <int*,ulong,double,double,double,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccSymmetrize");
        
        /// <summary>
        /// Apply a general affine transformation matrix `affineTransform' (16 entries
        /// of a 4x4 matrix, by row; only the 12 first can be provided for convenience)
        /// to the entities `dimTags' in the OpenCASCADE CAD representation.
        /// </summary>

        public static unsafe delegate* <int*,ulong,double*,ulong,int*,void> gmshModelOccAffineTransform; gmshModelOccAffineTransform = (delegate* <int*,ulong,double*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccAffineTransform");
        
        /// <summary>
        /// Copy the entities `dimTags' in the OpenCASCADE CAD representation; the new
        /// entities are returned in `outDimTags'.
        /// </summary>

        public static unsafe delegate* <int*,ulong,IntPtr*,ulong*,int*,void> gmshModelOccCopy; gmshModelOccCopy = (delegate* <int*,ulong,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccCopy");
        
        /// <summary>
        /// Remove the entities `dimTags' in the OpenCASCADE CAD representation,
        /// provided that they are not on the boundary of higher-dimensional entities.
        /// If `recursive' is true, remove all the entities on their boundaries, down
        /// to dimension 0.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int,int*,void> gmshModelOccRemove; gmshModelOccRemove = (delegate* <int*,ulong,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccRemove");
        
        /// <summary>
        /// Remove all duplicate entities in the OpenCASCADE CAD representation
        /// (different entities at the same geometrical location) after intersecting
        /// (using boolean fragments) all highest dimensional entities.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshModelOccRemoveAllDuplicates; gmshModelOccRemoveAllDuplicates = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccRemoveAllDuplicates");
        
        /// <summary>
        /// Apply various healing procedures to the entities `dimTags' (or to all the
        /// entities in the model if `dimTags' is empty) in the OpenCASCADE CAD
        /// representation. Return the healed entities in `outDimTags'.
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,int*,ulong,double,int,int,int,int,int,int*,void> gmshModelOccHealShapes; gmshModelOccHealShapes = (delegate* <IntPtr*,ulong*,int*,ulong,double,int,int,int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccHealShapes");
        
        /// <summary>
        /// Convert the entities `dimTags' to NURBS.
        /// </summary>

        public static unsafe delegate* <int*,ulong,int*,void> gmshModelOccConvertToNURBS; gmshModelOccConvertToNURBS = (delegate* <int*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccConvertToNURBS");
        
        /// <summary>
        /// Import BREP, STEP or IGES shapes from the file `fileName' in the
        /// OpenCASCADE CAD representation. The imported entities are returned in
        /// `outDimTags'. If the optional argument `highestDimOnly' is set, only import
        /// the highest dimensional entities in the file. The optional argument
        /// `format' can be used to force the format of the file (currently "brep",
        /// "step" or "iges").
        /// </summary>

        public static unsafe delegate* <nint,IntPtr*,ulong*,int,nint,int*,void> gmshModelOccImportShapes; gmshModelOccImportShapes = (delegate* <nint,IntPtr*,ulong*,int,nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccImportShapes");
        
        /// <summary>
        /// Imports an OpenCASCADE `shape' by providing a pointer to a native
        /// OpenCASCADE `TopoDS_Shape' object (passed as a pointer to void). The
        /// imported entities are returned in `outDimTags'. If the optional argument
        /// `highestDimOnly' is set, only import the highest dimensional entities in
        /// `shape'. In Python, this function can be used for integration with
        /// PythonOCC, in which the SwigPyObject pointer of `TopoDS_Shape' must be
        /// passed as an int to `shape', i.e., `shape = int(pythonocc_shape.this)'.
        /// Warning: this function is unsafe, as providing an invalid pointer will lead
        /// to undefined behavior.
        /// </summary>

        public static unsafe delegate* <void*,IntPtr*,ulong*,int,int*,void> gmshModelOccImportShapesNativePointer; gmshModelOccImportShapesNativePointer = (delegate* <void*,IntPtr*,ulong*,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccImportShapesNativePointer");
        
        /// <summary>
        /// Get all the OpenCASCADE entities. If `dim' is &gt;= 0, return only the
        /// entities of the specified dimension (e.g. points if `dim' == 0). The
        /// entities are returned as a vector of (dim, tag) integer pairs.
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,int,int*,void> gmshModelOccGetEntities; gmshModelOccGetEntities = (delegate* <IntPtr*,ulong*,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccGetEntities");
        
        /// <summary>
        /// Get the OpenCASCADE entities in the bounding box defined by the two points
        /// (`xmin', `ymin', `zmin') and (`xmax', `ymax', `zmax'). If `dim' is &gt;= 0,
        /// return only the entities of the specified dimension (e.g. points if `dim'
        /// == 0).
        /// </summary>

        public static unsafe delegate* <double,double,double,double,double,double,IntPtr*,ulong*,int,int*,void> gmshModelOccGetEntitiesInBoundingBox; gmshModelOccGetEntitiesInBoundingBox = (delegate* <double,double,double,double,double,double,IntPtr*,ulong*,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccGetEntitiesInBoundingBox");
        
        /// <summary>
        /// Get the bounding box (`xmin', `ymin', `zmin'), (`xmax', `ymax', `zmax') of
        /// the OpenCASCADE entity of dimension `dim' and tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,int,double*,double*,double*,double*,double*,double*,int*,void> gmshModelOccGetBoundingBox; gmshModelOccGetBoundingBox = (delegate* <int,int,double*,double*,double*,double*,double*,double*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccGetBoundingBox");
        
        /// <summary>
        /// Get the tags `curveLoopTags' of the curve loops making up the surface of
        /// tag `surfaceTag', as well as the tags `curveTags' of the curves making up
        /// each curve loop.
        /// </summary>

        public static unsafe delegate* <int,IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,int*,void> gmshModelOccGetCurveLoops; gmshModelOccGetCurveLoops = (delegate* <int,IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccGetCurveLoops");
        
        /// <summary>
        /// Get the tags `surfaceLoopTags' of the surface loops making up the volume of
        /// tag `volumeTag', as well as the tags `surfaceTags' of the surfaces making
        /// up each surface loop.
        /// </summary>

        public static unsafe delegate* <int,IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,int*,void> gmshModelOccGetSurfaceLoops; gmshModelOccGetSurfaceLoops = (delegate* <int,IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccGetSurfaceLoops");
        
        /// <summary>
        /// Get the mass of the OpenCASCADE entity of dimension `dim' and tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,int,double*,int*,void> gmshModelOccGetMass; gmshModelOccGetMass = (delegate* <int,int,double*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccGetMass");
        
        /// <summary>
        /// Get the center of mass of the OpenCASCADE entity of dimension `dim' and tag
        /// `tag'.
        /// </summary>

        public static unsafe delegate* <int,int,double*,double*,double*,int*,void> gmshModelOccGetCenterOfMass; gmshModelOccGetCenterOfMass = (delegate* <int,int,double*,double*,double*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccGetCenterOfMass");
        
        /// <summary>
        /// Get the matrix of inertia (by row) of the OpenCASCADE entity of dimension
        /// `dim' and tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,int,IntPtr*,ulong*,int*,void> gmshModelOccGetMatrixOfInertia; gmshModelOccGetMatrixOfInertia = (delegate* <int,int,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccGetMatrixOfInertia");
        
        /// <summary>
        /// Get the maximum tag of entities of dimension `dim' in the OpenCASCADE CAD
        /// representation.
        /// </summary>

        public static unsafe delegate* <int,int*,int> gmshModelOccGetMaxTag; gmshModelOccGetMaxTag = (delegate* <int,int*,int>)NativeLibrary.GetExport(Handle, "gmshModelOccGetMaxTag");
        
        /// <summary>
        /// Set the maximum tag `maxTag' for entities of dimension `dim' in the
        /// OpenCASCADE CAD representation.
        /// </summary>

        public static unsafe delegate* <int,int,int*,void> gmshModelOccSetMaxTag; gmshModelOccSetMaxTag = (delegate* <int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccSetMaxTag");
        
        /// <summary>
        /// Synchronize the OpenCASCADE CAD representation with the current Gmsh model.
        /// This can be called at any time, but since it involves a non trivial amount
        /// of processing, the number of synchronization points should normally be
        /// minimized. Without synchronization the entities in the OpenCASCADE CAD
        /// representation are not available to any function outside of the OpenCASCADE
        /// CAD kernel functions.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshModelOccSynchronize; gmshModelOccSynchronize = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccSynchronize");
        
        /// <summary>
        /// Set a mesh size constraint on the entities `dimTags' in the OpenCASCADE CAD
        /// representation. Currently only entities of dimension 0 (points) are
        /// handled.
        /// </summary>

        public static unsafe delegate* <int*,ulong,double,int*,void> gmshModelOccMeshSetSize; gmshModelOccMeshSetSize = (delegate* <int*,ulong,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshModelOccMeshSetSize");
        
        /// <summary>
        /// Add a new post-processing view, with name `name'. If `tag' is positive use
        /// it (and remove the view with that tag if it already exists), otherwise
        /// associate a new tag. Return the view tag.
        /// </summary>

        public static unsafe delegate* <nint,int,int*,int> gmshViewAdd; gmshViewAdd = (delegate* <nint,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshViewAdd");
        
        /// <summary>
        /// Remove the view with tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,int*,void> gmshViewRemove; gmshViewRemove = (delegate* <int,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewRemove");
        
        /// <summary>
        /// Get the index of the view with tag `tag' in the list of currently loaded
        /// views. This dynamic index (it can change when views are removed) is used to
        /// access view options.
        /// </summary>

        public static unsafe delegate* <int,int*,int> gmshViewGetIndex; gmshViewGetIndex = (delegate* <int,int*,int>)NativeLibrary.GetExport(Handle, "gmshViewGetIndex");
        
        /// <summary>
        /// Get the tags of all views.
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,int*,void> gmshViewGetTags; gmshViewGetTags = (delegate* <IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewGetTags");
        
        /// <summary>
        /// Add model-based post-processing data to the view with tag `tag'.
        /// `modelName' identifies the model the data is attached to. `dataType'
        /// specifies the type of data, currently either "NodeData", "ElementData" or
        /// "ElementNodeData". `step' specifies the identifier (&gt;= 0) of the data in a
        /// sequence. `tags' gives the tags of the nodes or elements in the mesh to
        /// which the data is associated. `data' is a vector of the same length as
        /// `tags': each entry is the vector of double precision numbers representing
        /// the data associated with the corresponding tag. The optional `time'
        /// argument associate a time value with the data. `numComponents' gives the
        /// number of data components (1 for scalar data, 3 for vector data, etc.) per
        /// entity; if negative, it is automatically inferred (when possible) from the
        /// input data. `partition' allows one to specify data in several sub-sets.
        /// </summary>

        public static unsafe delegate* <int,int,nint,nint,ulong*,ulong,IntPtr*,ulong*,ulong,double,int,int,int*,void> gmshViewAddModelData; gmshViewAddModelData = (delegate* <int,int,nint,nint,ulong*,ulong,IntPtr*,ulong*,ulong,double,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewAddModelData");
        
        /// <summary>
        /// Add homogeneous model-based post-processing data to the view with tag
        /// `tag'. The arguments have the same meaning as in `addModelData', except
        /// that `data' is supposed to be homogeneous and is thus flattened in a single
        /// vector. For data types that can lead to different data sizes per tag (like
        /// "ElementNodeData"), the data should be padded.
        /// </summary>

        public static unsafe delegate* <int,int,nint,nint,ulong*,ulong,double*,ulong,double,int,int,int*,void> gmshViewAddHomogeneousModelData; gmshViewAddHomogeneousModelData = (delegate* <int,int,nint,nint,ulong*,ulong,double*,ulong,double,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewAddHomogeneousModelData");
        
        /// <summary>
        /// Get model-based post-processing data from the view with tag `tag' at step
        /// `step'. Return the `data' associated to the nodes or the elements with tags
        /// `tags', as well as the `dataType' and the number of components
        /// `numComponents'.
        /// </summary>

        public static unsafe delegate* <int,int,IntPtr*,IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,double*,int*,int*,void> gmshViewGetModelData; gmshViewGetModelData = (delegate* <int,int,IntPtr*,IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,double*,int*,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewGetModelData");
        
        /// <summary>
        /// Get homogeneous model-based post-processing data from the view with tag
        /// `tag' at step `step'. The arguments have the same meaning as in
        /// `getModelData', except that `data' is returned flattened in a single
        /// vector, with the appropriate padding if necessary.
        /// </summary>

        public static unsafe delegate* <int,int,IntPtr*,IntPtr*,ulong*,IntPtr*,ulong*,double*,int*,int*,void> gmshViewGetHomogeneousModelData; gmshViewGetHomogeneousModelData = (delegate* <int,int,IntPtr*,IntPtr*,ulong*,IntPtr*,ulong*,double*,int*,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewGetHomogeneousModelData");
        
        /// <summary>
        /// Add list-based post-processing data to the view with tag `tag'. List-based
        /// datasets are independent from any model and any mesh. `dataType' identifies
        /// the data by concatenating the field type ("S" for scalar, "V" for vector,
        /// "T" for tensor) and the element type ("P" for point, "L" for line, "T" for
        /// triangle, "S" for tetrahedron, "I" for prism, "H" for hexaHedron, "Y" for
        /// pyramid). For example `dataType' should be "ST" for a scalar field on
        /// triangles. `numEle' gives the number of elements in the data. `data'
        /// contains the data for the `numEle' elements, concatenated, with node
        /// coordinates followed by values per node, repeated for each step: [e1x1,
        /// ..., e1xn, e1y1, ..., e1yn, e1z1, ..., e1zn, e1v1..., e1vN, e2x1, ...].
        /// </summary>

        public static unsafe delegate* <int,nint,int,double*,ulong,int*,void> gmshViewAddListData; gmshViewAddListData = (delegate* <int,nint,int,double*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewAddListData");
        
        /// <summary>
        /// Get list-based post-processing data from the view with tag `tag'. Return
        /// the types `dataTypes', the number of elements `numElements' for each data
        /// type and the `data' for each data type.
        /// </summary>

        public static unsafe delegate* <int,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,int*,void> gmshViewGetListData; gmshViewGetListData = (delegate* <int,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewGetListData");
        
        /// <summary>
        /// Add a string to a list-based post-processing view with tag `tag'. If
        /// `coord' contains 3 coordinates the string is positioned in the 3D model
        /// space ("3D string"); if it contains 2 coordinates it is positioned in the
        /// 2D graphics viewport ("2D string"). `data' contains one or more (for
        /// multistep views) strings. `style' contains key-value pairs of styling
        /// parameters, concatenated. Available keys are "Font" (possible values:
        /// "Times-Roman", "Times-Bold", "Times-Italic", "Times-BoldItalic",
        /// "Helvetica", "Helvetica-Bold", "Helvetica-Oblique", "Helvetica-
        /// BoldOblique", "Courier", "Courier-Bold", "Courier-Oblique", "Courier-
        /// BoldOblique", "Symbol", "ZapfDingbats", "Screen"), "FontSize" and "Align"
        /// (possible values: "Left" or "BottomLeft", "Center" or "BottomCenter",
        /// "Right" or "BottomRight", "TopLeft", "TopCenter", "TopRight", "CenterLeft",
        /// "CenterCenter", "CenterRight").
        /// </summary>

        public static unsafe delegate* <int,double*,ulong,IntPtr*,ulong,IntPtr*,ulong,int*,void> gmshViewAddListDataString; gmshViewAddListDataString = (delegate* <int,double*,ulong,IntPtr*,ulong,IntPtr*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewAddListDataString");
        
        /// <summary>
        /// Get list-based post-processing data strings (2D strings if `dim' = 2, 3D
        /// strings if `dim' = 3) from the view with tag `tag'. Return the coordinates
        /// in `coord', the strings in `data' and the styles in `style'.
        /// </summary>

        public static unsafe delegate* <int,int,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int*,void> gmshViewGetListDataStrings; gmshViewGetListDataStrings = (delegate* <int,int,IntPtr*,ulong*,IntPtr*,ulong*,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewGetListDataStrings");
        
        /// <summary>
        /// Set interpolation matrices for the element family `type' ("Line",
        /// "Triangle", "Quadrangle", "Tetrahedron", "Hexahedron", "Prism", "Pyramid")
        /// in the view `tag'. The approximation of the values over an element is
        /// written as a linear combination of `d' basis functions f_i(u, v, w) =
        /// sum_(j = 0, ..., `d' - 1) `coef'[i][j] u^`exp'[j][0] v^`exp'[j][1]
        /// w^`exp'[j][2], i = 0, ..., `d'-1, with u, v, w the coordinates in the
        /// reference element. The `coef' matrix (of size `d' x `d') and the `exp'
        /// matrix (of size `d' x 3) are stored as vectors, by row. If `dGeo' is
        /// positive, use `coefGeo' and `expGeo' to define the interpolation of the x,
        /// y, z coordinates of the element in terms of the u, v, w coordinates, in
        /// exactly the same way. If `d' 
        /// &lt;
        /// 0, remove the interpolation matrices.
        /// </summary>

        public static unsafe delegate* <int,nint,int,double*,ulong,double*,ulong,int,double*,ulong,double*,ulong,int*,void> gmshViewSetInterpolationMatrices; gmshViewSetInterpolationMatrices = (delegate* <int,nint,int,double*,ulong,double*,ulong,int,double*,ulong,double*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewSetInterpolationMatrices");
        
        /// <summary>
        /// Add a post-processing view as an `alias' of the reference view with tag
        /// `refTag'. If `copyOptions' is set, copy the options of the reference view.
        /// If `tag' is positive use it (and remove the view with that tag if it
        /// already exists), otherwise associate a new tag. Return the view tag.
        /// </summary>

        public static unsafe delegate* <int,int,int,int*,int> gmshViewAddAlias; gmshViewAddAlias = (delegate* <int,int,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshViewAddAlias");
        
        /// <summary>
        /// Combine elements (if `what' == "elements") or steps (if `what' == "steps")
        /// of all views (`how' == "all"), all visible views (`how' == "visible") or
        /// all views having the same name (`how' == "name"). Remove original views if
        /// `remove' is set.
        /// </summary>

        public static unsafe delegate* <nint,nint,int,int,int*,void> gmshViewCombine; gmshViewCombine = (delegate* <nint,nint,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewCombine");
        
        /// <summary>
        /// Probe the view `tag' for its `value' at point (`x', `y', `z'). If no match
        /// is found, `value' is returned empty. Return only the value at step `step'
        /// is `step' is positive. Return only values with `numComp' if `numComp' is
        /// positive. Return the gradient of the `value' if `gradient' is set. If
        /// `distanceMax' is zero, only return a result if an exact match inside an
        /// element in the view is found; if `distanceMax' is positive and an exact
        /// match is not found, return the value at the closest node if it is closer
        /// than `distanceMax'; if `distanceMax' is negative and an exact match is not
        /// found, always return the value at the closest node. The distance to the
        /// match is returned in `distance'. Return the result from the element
        /// described by its coordinates if `xElementCoord', `yElementCoord' and
        /// `zElementCoord' are provided. If `dim' is &gt;= 0, return only matches from
        /// elements of the specified dimension.
        /// </summary>

        public static unsafe delegate* <int,double,double,double,IntPtr*,ulong*,double*,int,int,int,double,double*,ulong,double*,ulong,double*,ulong,int,int*,void> gmshViewProbe; gmshViewProbe = (delegate* <int,double,double,double,IntPtr*,ulong*,double*,int,int,int,double,double*,ulong,double*,ulong,double*,ulong,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewProbe");
        
        /// <summary>
        /// Write the view to a file `fileName'. The export format is determined by the
        /// file extension. Append to the file if `append' is set.
        /// </summary>

        public static unsafe delegate* <int,nint,int,int*,void> gmshViewWrite; gmshViewWrite = (delegate* <int,nint,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewWrite");
        
        /// <summary>
        /// Set the global visibility of the view `tag' per window to `value', where
        /// `windowIndex' identifies the window in the window list.
        /// </summary>

        public static unsafe delegate* <int,int,int,int*,void> gmshViewSetVisibilityPerWindow; gmshViewSetVisibilityPerWindow = (delegate* <int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewSetVisibilityPerWindow");
        
        /// <summary>
        /// Set the numerical option `name' to value `value' for the view with tag
        /// `tag'.
        /// </summary>

        public static unsafe delegate* <int,nint,double,int*,void> gmshViewOptionSetNumber; gmshViewOptionSetNumber = (delegate* <int,nint,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewOptionSetNumber");
        
        /// <summary>
        /// Get the `value' of the numerical option `name' for the view with tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,nint,double*,int*,void> gmshViewOptionGetNumber; gmshViewOptionGetNumber = (delegate* <int,nint,double*,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewOptionGetNumber");
        
        /// <summary>
        /// Set the string option `name' to value `value' for the view with tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,nint,nint,int*,void> gmshViewOptionSetString; gmshViewOptionSetString = (delegate* <int,nint,nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewOptionSetString");
        
        /// <summary>
        /// Get the `value' of the string option `name' for the view with tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,nint,IntPtr*,int*,void> gmshViewOptionGetString; gmshViewOptionGetString = (delegate* <int,nint,IntPtr*,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewOptionGetString");
        
        /// <summary>
        /// Set the color option `name' to the RGBA value (`r', `g', `b', `a') for the
        /// view with tag `tag', where where `r', `g', `b' and `a' should be integers
        /// between 0 and 255.
        /// </summary>

        public static unsafe delegate* <int,nint,int,int,int,int,int*,void> gmshViewOptionSetColor; gmshViewOptionSetColor = (delegate* <int,nint,int,int,int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewOptionSetColor");
        
        /// <summary>
        /// Get the `r', `g', `b', `a' value of the color option `name' for the view
        /// with tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,nint,int*,int*,int*,int*,int*,void> gmshViewOptionGetColor; gmshViewOptionGetColor = (delegate* <int,nint,int*,int*,int*,int*,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewOptionGetColor");
        
        /// <summary>
        /// Copy the options from the view with tag `refTag' to the view with tag
        /// `tag'.
        /// </summary>

        public static unsafe delegate* <int,int,int*,void> gmshViewOptionCopy; gmshViewOptionCopy = (delegate* <int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshViewOptionCopy");
        
        /// <summary>
        /// Set the numerical option `option' to the value `value' for plugin `name'.
        /// </summary>

        public static unsafe delegate* <nint,nint,double,int*,void> gmshPluginSetNumber; gmshPluginSetNumber = (delegate* <nint,nint,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshPluginSetNumber");
        
        /// <summary>
        /// Set the string option `option' to the value `value' for plugin `name'.
        /// </summary>

        public static unsafe delegate* <nint,nint,nint,int*,void> gmshPluginSetString; gmshPluginSetString = (delegate* <nint,nint,nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshPluginSetString");
        
        /// <summary>
        /// Run the plugin `name'. Return the tag of the created view (if any).
        /// </summary>

        public static unsafe delegate* <nint,int*,int> gmshPluginRun; gmshPluginRun = (delegate* <nint,int*,int>)NativeLibrary.GetExport(Handle, "gmshPluginRun");
        
        /// <summary>
        /// Draw all the OpenGL scenes.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshGraphicsDraw; gmshGraphicsDraw = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshGraphicsDraw");
        
        /// <summary>
        /// Create the FLTK graphical user interface. Can only be called in the main
        /// thread.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshFltkInitialize; gmshFltkInitialize = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshFltkInitialize");
        
        /// <summary>
        /// Close the FLTK graphical user interface. Can only be called in the main
        /// thread.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshFltkFinalize; gmshFltkFinalize = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshFltkFinalize");
        
        /// <summary>
        /// Wait at most `time' seconds for user interface events and return. If `time'
        /// &lt;
        /// 0, wait indefinitely. First automatically create the user interface if it
        /// has not yet been initialized. Can only be called in the main thread.
        /// </summary>

        public static unsafe delegate* <double,int*,void> gmshFltkWait; gmshFltkWait = (delegate* <double,int*,void>)NativeLibrary.GetExport(Handle, "gmshFltkWait");
        
        /// <summary>
        /// Update the user interface (potentially creating new widgets and windows).
        /// First automatically create the user interface if it has not yet been
        /// initialized. Can only be called in the main thread: use `awake("update")'
        /// to trigger an update of the user interface from another thread.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshFltkUpdate; gmshFltkUpdate = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshFltkUpdate");
        
        /// <summary>
        /// Awake the main user interface thread and process pending events, and
        /// optionally perform an action (currently the only `action' allowed is
        /// "update").
        /// </summary>

        public static unsafe delegate* <nint,int*,void> gmshFltkAwake; gmshFltkAwake = (delegate* <nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshFltkAwake");
        
        /// <summary>
        /// Block the current thread until it can safely modify the user interface.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshFltkLock; gmshFltkLock = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshFltkLock");
        
        /// <summary>
        /// Release the lock that was set using lock.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshFltkUnlock; gmshFltkUnlock = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshFltkUnlock");
        
        /// <summary>
        /// Run the event loop of the graphical user interface, i.e. repeatedly call
        /// `wait()'. First automatically create the user interface if it has not yet
        /// been initialized. Can only be called in the main thread.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshFltkRun; gmshFltkRun = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshFltkRun");
        
        /// <summary>
        /// Check if the user interface is available (e.g. to detect if it has been
        /// closed).
        /// </summary>

        public static unsafe delegate* <int*,int> gmshFltkIsAvailable; gmshFltkIsAvailable = (delegate* <int*,int>)NativeLibrary.GetExport(Handle, "gmshFltkIsAvailable");
        
        /// <summary>
        /// Select entities in the user interface. If `dim' is &gt;= 0, return only the
        /// entities of the specified dimension (e.g. points if `dim' == 0).
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,int,int*,int> gmshFltkSelectEntities; gmshFltkSelectEntities = (delegate* <IntPtr*,ulong*,int,int*,int>)NativeLibrary.GetExport(Handle, "gmshFltkSelectEntities");
        
        /// <summary>
        /// Select elements in the user interface.
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,int*,int> gmshFltkSelectElements; gmshFltkSelectElements = (delegate* <IntPtr*,ulong*,int*,int>)NativeLibrary.GetExport(Handle, "gmshFltkSelectElements");
        
        /// <summary>
        /// Select views in the user interface.
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,int*,int> gmshFltkSelectViews; gmshFltkSelectViews = (delegate* <IntPtr*,ulong*,int*,int>)NativeLibrary.GetExport(Handle, "gmshFltkSelectViews");
        
        /// <summary>
        /// Split the current window horizontally (if `how' = "h") or vertically (if
        /// `how' = "v"), using ratio `ratio'. If `how' = "u", restore a single window.
        /// </summary>

        public static unsafe delegate* <nint,double,int*,void> gmshFltkSplitCurrentWindow; gmshFltkSplitCurrentWindow = (delegate* <nint,double,int*,void>)NativeLibrary.GetExport(Handle, "gmshFltkSplitCurrentWindow");
        
        /// <summary>
        /// Set the current window by speficying its index (starting at 0) in the list
        /// of all windows. When new windows are created by splits, new windows are
        /// appended at the end of the list.
        /// </summary>

        public static unsafe delegate* <int,int*,void> gmshFltkSetCurrentWindow; gmshFltkSetCurrentWindow = (delegate* <int,int*,void>)NativeLibrary.GetExport(Handle, "gmshFltkSetCurrentWindow");
        
        /// <summary>
        /// Set a status message in the current window. If `graphics' is set, display
        /// the message inside the graphic window instead of the status bar.
        /// </summary>

        public static unsafe delegate* <nint,int,int*,void> gmshFltkSetStatusMessage; gmshFltkSetStatusMessage = (delegate* <nint,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshFltkSetStatusMessage");
        
        /// <summary>
        /// Show context window for the entity of dimension `dim' and tag `tag'.
        /// </summary>

        public static unsafe delegate* <int,int,int*,void> gmshFltkShowContextWindow; gmshFltkShowContextWindow = (delegate* <int,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshFltkShowContextWindow");
        
        /// <summary>
        /// Open the `name' item in the menu tree.
        /// </summary>

        public static unsafe delegate* <nint,int*,void> gmshFltkOpenTreeItem; gmshFltkOpenTreeItem = (delegate* <nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshFltkOpenTreeItem");
        
        /// <summary>
        /// Close the `name' item in the menu tree.
        /// </summary>

        public static unsafe delegate* <nint,int*,void> gmshFltkCloseTreeItem; gmshFltkCloseTreeItem = (delegate* <nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshFltkCloseTreeItem");
        
        /// <summary>
        /// Get the names of the variables in the Gmsh parser matching the `search'
        /// regular expression. If `search' is empty, return all the names.
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,nint,int*,void> gmshParserGetNames; gmshParserGetNames = (delegate* <IntPtr*,ulong*,nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshParserGetNames");
        
        /// <summary>
        /// Set the value of the number variable `name' in the Gmsh parser. Create the
        /// variable if it does not exist; update the value if the variable exists.
        /// </summary>

        public static unsafe delegate* <nint,double*,ulong,int*,void> gmshParserSetNumber; gmshParserSetNumber = (delegate* <nint,double*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshParserSetNumber");
        
        /// <summary>
        /// Set the value of the string variable `name' in the Gmsh parser. Create the
        /// variable if it does not exist; update the value if the variable exists.
        /// </summary>

        public static unsafe delegate* <nint,IntPtr*,ulong,int*,void> gmshParserSetString; gmshParserSetString = (delegate* <nint,IntPtr*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshParserSetString");
        
        /// <summary>
        /// Get the value of the number variable `name' from the Gmsh parser. Return an
        /// empty vector if the variable does not exist.
        /// </summary>

        public static unsafe delegate* <nint,IntPtr*,ulong*,int*,void> gmshParserGetNumber; gmshParserGetNumber = (delegate* <nint,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshParserGetNumber");
        
        /// <summary>
        /// Get the value of the string variable `name' from the Gmsh parser. Return an
        /// empty vector if the variable does not exist.
        /// </summary>

        public static unsafe delegate* <nint,IntPtr*,ulong*,int*,void> gmshParserGetString; gmshParserGetString = (delegate* <nint,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshParserGetString");
        
        /// <summary>
        /// Clear all the Gmsh parser variables, or remove a single variable if `name'
        /// is given.
        /// </summary>

        public static unsafe delegate* <nint,int*,void> gmshParserClear; gmshParserClear = (delegate* <nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshParserClear");
        
        /// <summary>
        /// Parse the file `fileName' with the Gmsh parser.
        /// </summary>

        public static unsafe delegate* <nint,int*,void> gmshParserParse; gmshParserParse = (delegate* <nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshParserParse");
        
        /// <summary>
        /// Set one or more parameters in the ONELAB database, encoded in `format'.
        /// </summary>

        public static unsafe delegate* <nint,nint,int*,void> gmshOnelabSet; gmshOnelabSet = (delegate* <nint,nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshOnelabSet");
        
        /// <summary>
        /// Get all the parameters (or a single one if `name' is specified) from the
        /// ONELAB database, encoded in `format'.
        /// </summary>

        public static unsafe delegate* <IntPtr*,nint,nint,int*,void> gmshOnelabGet; gmshOnelabGet = (delegate* <IntPtr*,nint,nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshOnelabGet");
        
        /// <summary>
        /// Get the names of the parameters in the ONELAB database matching the
        /// `search' regular expression. If `search' is empty, return all the names.
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,nint,int*,void> gmshOnelabGetNames; gmshOnelabGetNames = (delegate* <IntPtr*,ulong*,nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshOnelabGetNames");
        
        /// <summary>
        /// Set the value of the number parameter `name' in the ONELAB database. Create
        /// the parameter if it does not exist; update the value if the parameter
        /// exists.
        /// </summary>

        public static unsafe delegate* <nint,double*,ulong,int*,void> gmshOnelabSetNumber; gmshOnelabSetNumber = (delegate* <nint,double*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshOnelabSetNumber");
        
        /// <summary>
        /// Set the value of the string parameter `name' in the ONELAB database. Create
        /// the parameter if it does not exist; update the value if the parameter
        /// exists.
        /// </summary>

        public static unsafe delegate* <nint,IntPtr*,ulong,int*,void> gmshOnelabSetString; gmshOnelabSetString = (delegate* <nint,IntPtr*,ulong,int*,void>)NativeLibrary.GetExport(Handle, "gmshOnelabSetString");
        
        /// <summary>
        /// Get the value of the number parameter `name' from the ONELAB database.
        /// Return an empty vector if the parameter does not exist.
        /// </summary>

        public static unsafe delegate* <nint,IntPtr*,ulong*,int*,void> gmshOnelabGetNumber; gmshOnelabGetNumber = (delegate* <nint,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshOnelabGetNumber");
        
        /// <summary>
        /// Get the value of the string parameter `name' from the ONELAB database.
        /// Return an empty vector if the parameter does not exist.
        /// </summary>

        public static unsafe delegate* <nint,IntPtr*,ulong*,int*,void> gmshOnelabGetString; gmshOnelabGetString = (delegate* <nint,IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshOnelabGetString");
        
        /// <summary>
        /// Check if any parameters in the ONELAB database used by the client `name'
        /// have been changed.
        /// </summary>

        public static unsafe delegate* <nint,int*,int> gmshOnelabGetChanged; gmshOnelabGetChanged = (delegate* <nint,int*,int>)NativeLibrary.GetExport(Handle, "gmshOnelabGetChanged");
        
        /// <summary>
        /// Set the changed flag to value `value' for all the parameters in the ONELAB
        /// database used by the client `name'.
        /// </summary>

        public static unsafe delegate* <nint,int,int*,void> gmshOnelabSetChanged; gmshOnelabSetChanged = (delegate* <nint,int,int*,void>)NativeLibrary.GetExport(Handle, "gmshOnelabSetChanged");
        
        /// <summary>
        /// Clear the ONELAB database, or remove a single parameter if `name' is given.
        /// </summary>

        public static unsafe delegate* <nint,int*,void> gmshOnelabClear; gmshOnelabClear = (delegate* <nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshOnelabClear");
        
        /// <summary>
        /// Run a ONELAB client. If `name' is provided, create a new ONELAB client with
        /// name `name' and executes `command'. If not, try to run a client that might
        /// be linked to the processed input files.
        /// </summary>

        public static unsafe delegate* <nint,nint,int*,void> gmshOnelabRun; gmshOnelabRun = (delegate* <nint,nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshOnelabRun");
        
        /// <summary>
        /// Write a `message'. `level' can be "info", "warning" or "error".
        /// </summary>

        public static unsafe delegate* <nint,nint,int*,void> gmshLoggerWrite; gmshLoggerWrite = (delegate* <nint,nint,int*,void>)NativeLibrary.GetExport(Handle, "gmshLoggerWrite");
        
        /// <summary>
        /// Start logging messages.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshLoggerStart; gmshLoggerStart = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshLoggerStart");
        
        /// <summary>
        /// Get logged messages.
        /// </summary>

        public static unsafe delegate* <IntPtr*,ulong*,int*,void> gmshLoggerGet; gmshLoggerGet = (delegate* <IntPtr*,ulong*,int*,void>)NativeLibrary.GetExport(Handle, "gmshLoggerGet");
        
        /// <summary>
        /// Stop logging messages.
        /// </summary>

        public static unsafe delegate* <int*,void> gmshLoggerStop; gmshLoggerStop = (delegate* <int*,void>)NativeLibrary.GetExport(Handle, "gmshLoggerStop");
        
        /// <summary>
        /// Return wall clock time.
        /// </summary>

        public static unsafe delegate* <int*,double> gmshLoggerGetWallTime; gmshLoggerGetWallTime = (delegate* <int*,double>)NativeLibrary.GetExport(Handle, "gmshLoggerGetWallTime");
        
        /// <summary>
        /// Return CPU time.
        /// </summary>

        public static unsafe delegate* <int*,double> gmshLoggerGetCpuTime; gmshLoggerGetCpuTime = (delegate* <int*,double>)NativeLibrary.GetExport(Handle, "gmshLoggerGetCpuTime");
        
        /// <summary>
        /// Return last error message, if any.
        /// </summary>

        public static unsafe delegate* <IntPtr*,int*,void> gmshLoggerGetLastError; gmshLoggerGetLastError = (delegate* <IntPtr*,int*,void>)NativeLibrary.GetExport(Handle, "gmshLoggerGetLastError");
    }
}