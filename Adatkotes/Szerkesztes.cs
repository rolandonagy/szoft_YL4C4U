using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adatkotes
{
    public partial class Szerkesztes : Form
    {
        public CountryData Data;
        public Szerkesztes()
        {
            InitializeComponent();
        }

        private void Szerkesztes_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = Data;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
