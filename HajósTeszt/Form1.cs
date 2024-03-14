using System.Windows.Forms;

namespace HajósTeszt
{
    public partial class Form1 : Form
    {

        List<Kérdés> OsszesKerdes;
        List<Kérdés> AktivKerdes;
        int aktKerdes = 5;
        VálaszGomb válaszgomb1;
        VálaszGomb válaszgomb2;
        VálaszGomb válaszgomb3;
        public Form1()
        {
            InitializeComponent();
            válaszgomb1 = new VálaszGomb();
            válaszgomb1.Top = 50;
            Controls.Add(válaszgomb1);

            válaszgomb2 = new VálaszGomb();
            válaszgomb2.Top = 150;
            Controls.Add(válaszgomb2);

            válaszgomb3 = new VálaszGomb();
            válaszgomb3.Top = 250;
            Controls.Add(válaszgomb3);
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
            
            for (int i = 0; i < 7; i++)
            {
                KérdésMegjelenítés(AktivKerdes[i]);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}