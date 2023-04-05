using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyanite.Shell
{
    internal class Util
    {
        public static void DrawKyaniteLogo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"                                    /\");
            Console.WriteLine(@"                                   / /\");
            Console.WriteLine(@"                                  /\/  \");
            Console.WriteLine(@"                                 /  \   \");
            Console.WriteLine(@"                                /\   \  /\");
            Console.WriteLine(@"                               /  \   \/  \");
            Console.WriteLine(@"                               \  /\  /\  /");
            Console.WriteLine(@"                                \/  \/  \/");
            Console.WriteLine(@"                                 \  /   /");
            Console.WriteLine(@"                                  \/   /");
            Console.WriteLine(@"                                   \  /");
            Console.WriteLine(@"                                    \/");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void DrawKyanite(bool NewLine)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (NewLine)
            {
                Console.WriteLine("Kyanite");
            }
            else
            {
                Console.Write("Kyanite");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
