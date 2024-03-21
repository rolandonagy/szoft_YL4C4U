using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigyosJatek
{
    internal class Mereg : PictureBox
    {
        public static int Meret = 20;
        public Mereg()
        {
            Height = Meret;
            Width = Meret;
            BackColor = Color.Yellow;
        }
    }
}
