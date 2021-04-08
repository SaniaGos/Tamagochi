using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Tamagochi.Klasses;

namespace Tamagochi
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Go();
        }
    }
}
