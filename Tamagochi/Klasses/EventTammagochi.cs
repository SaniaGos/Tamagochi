using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Tamagochi.Klasses
{
    enum Move
    {
        Sleep = 1, Feed, Walk, Play, Treat
    }
    class EventTammagochi : EventArgs
    {
        public Move Move { get; private set; }
        public EventTammagochi(int move)
        {
            if (move == 1) Move = Move.Sleep;
            else if (move == 2) Move = Move.Feed;
            else if (move == 3) Move = Move.Walk;
            else if (move == 4) Move = Move.Play;
            else Move = Move.Treat;
        }
    }
}
