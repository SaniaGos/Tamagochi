using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Tamagochi.Klasses
{
    class Tamagochi
    {
        private int life;
        private int age;
        public Tamagochi()
        {
            life = 4;
            age = 0;
        }
        public bool IsSick()
        {
            return life <= 1;
        }
        public bool IsLive()
        {
            return life > 0;
        }
        public bool IsGrown()
        {
            return age >= 10;
        }
        private void Action(string need)
        {
            if (life == 0) throw new Exception("Tamagochi Die");
            life--;
            age++;
            DialogResult res = MessageBox.Show($"   {need}", "Tamagochi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                life++;
            }
        }
        public void Sleep(Object sender, EventTammagochi e)
        {
            if (e.Move != Move.Sleep) return;
            Action("I want to sleep!!!\n    Put to sleep ? ");
        }
    
        public void Play(Object sender, EventTammagochi e)
        {
            if (e.Move != Move.Play) return;
            Action("   I want to Play!!\n    Play with him?");
        }
        public void Walk(Object sender, EventTammagochi e)
        {
            if (e.Move != Move.Walk) return;
            Action("   I want to Walk!!!\n    Walk with him?");
        }
        public void Feed(Object sender, EventTammagochi e)
        {
            if (e.Move != Move.Feed) return;
            Action("   I am hungry!!!\n      Feed him?");
        }
        public void Theat(Object sender, EventTammagochi e)
        {
            if (e.Move != Move.Treat) return;
            Action("    I'm sick!!!\n    Treat him?");
            life = 4;
        }
    }
}
