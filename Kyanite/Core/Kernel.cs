using System;
using Sys = Cosmos.System;
using Kyanite.Logging;
using Kyanite.Shell;

namespace Kyanite.Core
{
    public class Kernel : Sys.Kernel
    {
        public const string Version = "1.0.2";

        /// <summary>
		/// A method called once when the kernel boots, Used to initialize the system.
		/// </summary>
        protected override void BeforeRun()
        {
            Logger.Log("Starting Kyanite...");

            // Initialise file system
            Logger.Log("Initialising file system...");
            FsManager.Initialise();

            Logger.Log("Kyanite booted succesfully!");

            // Clear console.
            Console.Clear();

            Util.DrawKyaniteLogo();
            Util.DrawKyanite(false);
            Console.WriteLine(" booted succesfully, type in 'help' to list all supported commands.\n");
        }

        /// <summary>
		/// Initializing Kyanite functions.
		/// </summary>
        protected override void Run()
        {
            // Initialize Kyanite prompt
            Logger.Log("Initializing Kyanite shell...");
            Shell.Shell.Initialize();
        }
    }
}
