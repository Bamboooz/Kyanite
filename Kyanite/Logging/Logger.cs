using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyanite.Logging
{
    internal class Logger
    {
        public static List<string> Logs = new List<string>();

        internal static void Log(string LogMessage)
        {
            Logs.Add(LogMessage);
        }

        internal static void ReadLogs()
        {
            foreach (string log in Logs)
            {
                Console.WriteLine("Log: " + log);
            }
        }
    }
}
