using System;

namespace Kyanite
{
    internal class Util
    {
        public static void DrawKyaniteLogo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(@"                /\     ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"                          _ _       ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(@"               /\/\    ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"   /\ /\_   _  __ _ _ __ (_) |_ ___ ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(@"              /  \ \   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"  / //_/ | | |/ _` | '_ \| | __/ _ \");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(@"              \  /\/   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@" / __ \| |_| | (_| | | | | | ||  __/");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(@"               \/ /    ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@" \/  \/ \__, |\__,_|_| |_|_|\__\___|");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(@"                \/     ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"        |___/     ");
            Console.WriteLine("");
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
