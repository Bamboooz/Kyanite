namespace Kyanite.Core
{
    internal static class Power
    {
        internal static void Shutdown()
        {
            Cosmos.System.Power.Shutdown();
        }

        internal static void Reboot()
        {
            Cosmos.System.Power.Reboot();
        }
    }
}