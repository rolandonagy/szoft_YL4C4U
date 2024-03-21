using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace KigyosJatek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int fej_x = 100;
        int fej_y = 100;
        int irány_x = 1;
        int irány_y = 0;
        int lepeszam;
        int hossz = 5;
        List<KigyóElem> kígyó = new List<KigyóElem>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            lepeszam++;
            fej_x += irány_x * KigyóElem.Méret;
            fej_y += irány_y * KigyóElem.Méret;

            foreach (Object item in Controls)
            {
                if (item is KigyóElem)
                {
                    KigyóElem k = (KigyóElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
                if (item is Hami)
                {
                    Hami hh = (Hami)item;
                    if (hh.Top == fej_y && hh.Left == fej_x)
                    {
                        hossz++;
                        Controls.Remove(hh);
                    }
                }
                if (item is Mereg)
                {
                    Mereg mm = (Mereg)item;
                    if (mm.Top == fej_y && mm.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            KigyóElem ke = new KigyóElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            kígyó.Add(ke);

            if (kígyó.Count > hossz)
            {
                KigyóElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }

            if (lepeszam % 2 == 1)
            {
                ke.BackColor = Color.Black;
            }

            if (lepeszam % 20 == 0)
            {
                Hami h = new Hami();
                Random rand = new Random();
                h.Left = rand.Next(this.ClientSize.Width/KigyóElem.Méret)* KigyóElem.Méret;
                h.Top = rand.Next(this.ClientSize.Height/KigyóElem.Méret) * KigyóElem.Méret;
                Controls.Add(h);
            }
            if (lepeszam % 40 == 0)
            {
                Mereg m = new Mereg();
                Random rand = new Random();
                m.Left = rand.Next(this.ClientSize.Width / KigyóElem.Méret) * KigyóElem.Méret;
                m.Top = rand.Next(this.ClientSize.Height / KigyóElem.Méret) * KigyóElem.Méret;
                Controls.Add(m);
            }
            Controls.Add(ke);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }
    }
}