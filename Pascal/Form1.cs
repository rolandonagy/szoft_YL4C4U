namespace Pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int m = 40;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Button b = new Button();
                    b.Width = m;
                    b.Height = m;
                    b.Left = j * m;
                    b.Top = i * m;
                    Controls.Add(b);
                    int p = Faktorialis(i) / (Faktorialis(j) * (Faktorialis(i - j)));
                    b.Text = p.ToString();  
                }
            }
        }

        int Faktorialis(int n)
        {
            if (n == 0) return 1;
            return n * Faktorialis(n - 1);
        }
    }
}