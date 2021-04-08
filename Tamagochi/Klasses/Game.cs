using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Tamagochi.Klasses
{

    class Game
    {
        private System.Timers.Timer timer;
        private event Action<Object, EventTammagochi> eventGame;
        private Tamagochi tamagochi;
        private int previousMove;
        public Game()
        {
            previousMove = -1;
            tamagochi = new Tamagochi();
            timer = new System.Timers.Timer();
        }
        private void End()
        {
            timer.Stop();
            MyView.Grown();
            DialogResult res = MessageBox.Show($"   End Game!!!\n    Tamagochi has grown.", "Tamagochi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res == DialogResult.OK) return;
        }
        private void Start(Object obj, ElapsedEventArgs e)
        {
            int move;
            do
            {
                move = MyRand.GetRand(1, 4);                    // генеруєм випадкову дію тамагочі
            }
            while (previousMove == move);                       // перевіряєм чи дія не повторюється
            if (tamagochi.IsSick()) move = 5;                   // перевіряєм чи не хворий
            previousMove = move;
            try
            {
                eventGame(this, new EventTammagochi(move));     // запускаєм наш Event
            }
            catch (Exception ex)
            {
                timer.Stop();
                MyView.Die();
                DialogResult res = MessageBox.Show($"   {ex.Message}!!!\n    Game over", "Tamagochi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK) return;
            }
            if (tamagochi.IsGrown()) End();
        }

        public void Go()
        {
            eventGame += tamagochi.Sleep;   // дабавляєм в наш Event методи від класу тамагочі
            eventGame += tamagochi.Feed;
            eventGame += tamagochi.Play;
            eventGame += tamagochi.Walk;
            eventGame += tamagochi.Theat;
            timer.Elapsed += Start;         // добавляєм в Event класу Timer метод обробки таймера
            timer.Interval = 3000;          // задаєм інтервал таймера
            timer.Start();                  // запускаєм таймер

            if (tamagochi.IsLive())
                Console.ReadKey();
        }
    }
}
