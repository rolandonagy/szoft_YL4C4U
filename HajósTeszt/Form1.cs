namespace HajósTeszt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kérdés> OsszesKerdes;
        List<Kérdés> AktivKerdes;
        int aktKerdes = 5;

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
;
            return kérdés;
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
        }
    }
}