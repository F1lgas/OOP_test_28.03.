using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test_OOP
{
    internal class herni_postava
    {
        String Jmeno { get; set; }
        int PozX = 0;
        int PozY = 0;
        public int level = 1;

        public herni_postava(string jmeno)
        {
            this.Jmeno = jmeno;
        }

        public int zmenaPoz(Label x, Label y, TextBox t1, TextBox t2)
        {
            int x2 = t1.Text();
            int y2 = t2.Text();

        }

        public override string ToString()
        {
            return "jmeno: " + Jmeno + " X: " + PozX + " Y: " + PozY + " lvl:" + level;
        }

        public int LvlUp(int lvl)
        {
            lvl++;
            return lvl;
        }
    }
}
