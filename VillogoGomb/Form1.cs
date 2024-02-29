namespace VillogoGomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int meret = 20;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int s = 0; s < 10; s++)
            {
                for (int o = 0; o < 10; o++)
                {
                    SzámolóGomb b = new SzámolóGomb();
                    /*
                    b.Width = meret;
                    b.Height = meret;
                    */
                    b.Left = o * meret;
                    b.Top = s * meret;
                    //b.Text = ((s + 1) * (o + 1)).ToString();
                    Controls.Add(b);
                }
            }
        }
    }
}