using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyanite.Logging
{
    internal class Logger
    {
        public static string[] Logs = {};

        internal static void Log(string LogMessage)
        {
            Logs.Append(LogMessage);
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
