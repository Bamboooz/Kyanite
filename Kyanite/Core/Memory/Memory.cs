namespace Kyanite.Core.Memory
{
    internal class Memory
    {
        private static uint MemTotal = Cosmos.Core.CPU.GetAmountOfRAM();
        private static uint MemUnavail = 0;
        private static uint MemUsed = 0;
        private static uint MemFree = 0;
        private static uint MemPercentUsed = 0;

        private static void Update()
        {
            MemTotal = Cosmos.Core.CPU.GetAmountOfRAM();
            MemUnavail = MemTotal - (uint)Cosmos.Core.GCImplementation.GetAvailableRAM();
            MemUsed = (Cosmos.Core.GCImplementation.GetUsedRAM() / 1024 / 1024) + MemUnavail;
            MemFree = MemTotal - MemUsed;
            MemPercentUsed = (uint)(((float)MemUsed / (float)MemTotal) * 100f);
        }

        public static uint Total()
        {
            Update();
            return MemTotal;
        }

        public static uint Used()
        {
            Update();
            return MemUsed;
        }

        public static uint Free()
        {
            Update();
            return MemFree;
        }

        public static uint Unavailable()
        {
            Update();
            return MemUnavail;
        }

        public static uint UserPerc()
        {
            Update();
            return MemPercentUsed;
        }
    }
}