namespace SzorzoTabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button b = new Button();
                    b.Width = 40;
                    b.Height = 40;
                    b.Left = i * 40;
                    b.Top = j * 40;
                    b.Text = ((i + 1) * (j + 1)).ToString();
                    Controls.Add(b);
                }
            }
        }
    }
}