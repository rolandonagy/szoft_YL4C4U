using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigyosJatek
{
    internal class KigyóElem : PictureBox
    {
        public static int Méret = 20;
        public KigyóElem()
        {
            Width = Méret;
            Height = Méret;
            BackColor = Color.Green;
        }
    }
}
