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
        int ir�ny_x = 1;
        int ir�ny_y = 0;
        int lepeszam;
        int hossz = 5;
        List<Kigy�Elem> k�gy� = new List<Kigy�Elem>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            lepeszam++;
            fej_x += ir�ny_x * Kigy�Elem.M�ret;
            fej_y += ir�ny_y * Kigy�Elem.M�ret;

            foreach (Object item in Controls)
            {
                if (item is Kigy�Elem)
                {
                    Kigy�Elem k = (Kigy�Elem)item;

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

            Kigy�Elem ke = new Kigy�Elem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            k�gy�.Add(ke);

            if (k�gy�.Count > hossz)
            {
                Kigy�Elem lev�gand� = k�gy�[0];
                k�gy�.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }

            if (lepeszam % 2 == 1)
            {
                ke.BackColor = Color.Black;
            }

            if (lepeszam % 20 == 0)
            {
                Hami h = new Hami();
                Random rand = new Random();
                h.Left = rand.Next(this.ClientSize.Width/Kigy�Elem.M�ret)* Kigy�Elem.M�ret;
                h.Top = rand.Next(this.ClientSize.Height/Kigy�Elem.M�ret) * Kigy�Elem.M�ret;
                Controls.Add(h);
            }
            if (lepeszam % 40 == 0)
            {
                Mereg m = new Mereg();
                Random rand = new Random();
                m.Left = rand.Next(this.ClientSize.Width / Kigy�Elem.M�ret) * Kigy�Elem.M�ret;
                m.Top = rand.Next(this.ClientSize.Height / Kigy�Elem.M�ret) * Kigy�Elem.M�ret;
                Controls.Add(m);
            }
            Controls.Add(ke);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }
        }
    }
}