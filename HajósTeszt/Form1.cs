using System.Security.Cryptography;
using System.Windows.Forms;

namespace HajósTeszt
{
    public partial class Form1 : Form
    {

        List<Kérdés> OsszesKerdes;
        List<Kérdés> AktivKerdes;
        int aktKerdes = 0;
        VálaszGomb válaszgomb1;
        VálaszGomb válaszgomb2;
        VálaszGomb válaszgomb3;
        public Form1()
        {
            InitializeComponent();
            válaszgomb1 = new VálaszGomb();
            válaszgomb1.Top = 50;
            válaszgomb1.Click += Válaszgomb1_Click;
            Controls.Add(válaszgomb1);

            válaszgomb2 = new VálaszGomb();
            válaszgomb2.Top = 150;
            válaszgomb2.Click += Válaszgomb2_Click;
            Controls.Add(válaszgomb2);

            válaszgomb3 = new VálaszGomb();
            válaszgomb3.Top = 250;
            válaszgomb3.Click += Válaszgomb3_Click;
            Controls.Add(válaszgomb3);
        }

        private void Válaszgomb3_Click(object? sender, EventArgs e)
        {
            switch (AktivKerdes[aktKerdes].HelyesVálasz)
            {
                case 1:
                    válaszgomb1.BackColor = Color.Red;
                    válaszgomb2.BackColor = Color.Red;
                    válaszgomb3.BackColor = Color.Green;
                    break;
                case 2:
                    válaszgomb2.BackColor = Color.Red;
                    válaszgomb3.BackColor = Color.Green;
                    válaszgomb1.BackColor = Color.Red;
                    break;
                case 3:
                    válaszgomb3.BackColor = Color.Green;
                    break;
                default:
                    break;
            }
        }

        private void Válaszgomb2_Click(object? sender, EventArgs e)
        {
            switch (AktivKerdes[aktKerdes].HelyesVálasz)
            {
                case 1:
                    válaszgomb1.BackColor = Color.Red;
                    válaszgomb2.BackColor = Color.Green;
                    válaszgomb3.BackColor = Color.Red;
                    break;
                case 2:
                    válaszgomb2.BackColor = Color.Green;
                    break;
                case 3:
                    válaszgomb3.BackColor = Color.Red;
                    válaszgomb2.BackColor = Color.Green;
                    válaszgomb1.BackColor = Color.Red;
                    break;
                default:
                    break;
            }
        }

        private void Válaszgomb1_Click(object? sender, EventArgs e)
        {
            switch (AktivKerdes[aktKerdes].HelyesVálasz)
            {
                case 1:
                    válaszgomb1.BackColor = Color.Green;
                    break;
                case 2:
                    válaszgomb2.BackColor = Color.Red;
                    válaszgomb1.BackColor = Color.Green;
                    válaszgomb3.BackColor = Color.Red;
                    break;
                case 3:
                    válaszgomb3.BackColor = Color.Red;
                    válaszgomb2.BackColor = Color.Red;
                    válaszgomb1.BackColor = Color.Green;
                    break;
                default:
                    break;
            }
        }

        List<Kérdés> Beolvasas()
        {
            List<Kérdés> kérdés = new List<Kérdés>();

            try
            {
                StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine() ?? "";
                    string[] reszsor = sor.Split("\t");
                    if (reszsor.Length != 7) continue;
                    Kérdés ker = new Kérdés();
                    ker.KérdésSzöveg = reszsor[1];
                    ker.Válasz1 = reszsor[2];
                    ker.Válasz2 = reszsor[3];
                    ker.Válasz3 = reszsor[4];
                    ker.URL = reszsor[5];

                    int.TryParse(reszsor[6], out int jval);
                    ker.HelyesVálasz = jval;
                    kérdés.Add(ker);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return kérdés;
        }

        void KérdésMegjelenítés(Kérdés kérdés)
        {
            label1.Text = kérdés.KérdésSzöveg;
            válaszgomb1.Text = kérdés.Válasz1;
            válaszgomb2.Text = kérdés.Válasz2;
            válaszgomb3.Text = kérdés.Válasz3;
            if (!string.IsNullOrEmpty(kérdés.URL))
            {
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kérdés.URL);
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AktivKerdes = new List<Kérdés>();
            OsszesKerdes = Beolvasas();
            for (int i = 0; i < 7; i++)
            {
                AktivKerdes.Add(OsszesKerdes[0]);
                OsszesKerdes.RemoveAt(0);
            }
            dataGridView1.DataSource = AktivKerdes;
            KérdésMegjelenítés(AktivKerdes[aktKerdes]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KérdésMegjelenítés(AktivKerdes[aktKerdes++]);
            if (aktKerdes == 7)
            {
                aktKerdes = 0;
            }
            válaszgomb1.BackColor = Color.LightGray;
            válaszgomb2.BackColor = Color.LightGray;
            válaszgomb3.BackColor = Color.LightGray;

        }
    }
}