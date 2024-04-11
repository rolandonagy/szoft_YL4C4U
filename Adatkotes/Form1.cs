using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace Adatkotes
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> l = new();
        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = l;
            dataGridView1.DataSource = countryDataBindingSource;
        }

        private void megny_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("european_countries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tomb = csv.GetRecords<CountryData>();
            foreach (var item in tomb)
            {
                l.Add(item);
            }
            sr.Close();
        }

        private void torl_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void szerk_Click(object sender, EventArgs e)
        {
            Szerkesztes fce = new Szerkesztes();
            fce.Data = countryDataBindingSource.Current as CountryData;
            fce.Show();
        }

        private void mentes_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            if (s.ShowDialog()==DialogResult.OK)
            {
                using (var writer = new StreamWriter(s.FileName))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(l);
                };
            }

            
        }
    }
}