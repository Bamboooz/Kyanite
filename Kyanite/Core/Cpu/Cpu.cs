namespace Kyanite.Core
{
    internal static class Cpu
    {
        private static string CpuModel = Cosmos.Core.CPU.GetCPUBrandString();
        private static ulong CpuUptime = Cosmos.Core.CPU.GetCPUUptime();
        private static string CpuVendor = Cosmos.Core.CPU.GetCPUVendorName();
        private static long CpuSpeed = Cosmos.Core.CPU.EstimateCPUSpeedFromName(Cosmos.Core.CPU.GetCPUBrandString());

        private static void Update()
        {
            CpuModel = Cosmos.Core.CPU.GetCPUBrandString();
            CpuUptime = Cosmos.Core.CPU.GetCPUUptime();
            CpuSpeed = Cosmos.Core.CPU.EstimateCPUSpeedFromName(CpuModel);
            CpuVendor = Cosmos.Core.CPU.GetCPUVendorName();
        }

        public static void Halt()
        {
            Cosmos.Core.CPU.Halt();
        }

        public static void Reboot()
        {
            Cosmos.Core.CPU.Reboot();
        }

        public static string Model()
        {
            Update();
            return CpuModel;
        }

        public static long Speed()
        {
            Update();
            return CpuSpeed;
        }

        public static ulong Uptime()
        {
            Update();
            return CpuUptime;
        }

        public static string Vendor()
        {
            Update();
            return CpuVendor;
        }
    }
}