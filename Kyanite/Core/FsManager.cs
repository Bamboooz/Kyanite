using System;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem.VFS;

namespace Kyanite.Core
{
    internal static class FsManager
    {
        /// <summary>
        /// The virtual file system.
        /// </summary>
        internal static Sys.FileSystem.CosmosVFS Fs;

        /// <summary>
        /// Initialise the virtual file system.
        /// </summary>
        internal static void Initialise()
        {
            Fs = new Sys.FileSystem.CosmosVFS();
            VFSManager.RegisterVFS(Fs);
        }

        internal static string Type()
        {
            return Fs.GetFileSystemType(@"0:\");
        }
    }
}
