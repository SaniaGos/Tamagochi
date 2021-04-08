using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi.Klasses
{
    static class MyView
    {
        public static void Die()
        {
            Console.WriteLine("\t▀█▀ ▄▀▄ █▄ ▄█ ▄▀▄ ▄▀▀  ▄▀▄ ▄▀ █   ▀     █▀▄ ▀ █▀▀");
            Console.WriteLine("\t █  █▀█ █ █ █ █▀█ █ ▀▌ █ █ █  █▀▄ █     █ █ █ █▀▀");
            Console.WriteLine("\t ▀  ▀ ▀ ▀   ▀ ▀ ▀ ▀▀▀   ▀   ▀ ▀ ▀ ▀     ▀▀  ▀ ▀▀▀");
            Console.WriteLine();
        }
        public static void Grown()
        {
            Console.WriteLine("\t▄▀▀  █▀▀▄ ▄▀▄ █   █ █▄ █ ");
            Console.WriteLine("\t█ ▀▌ █▐█▀ █ █ █ █ █ █ ▀█ ");
            Console.WriteLine("\t▀▀▀  ▀ ▀▀  ▀   ▀ ▀  ▀  ▀ ");
            Console.WriteLine();
        }
    }
}
