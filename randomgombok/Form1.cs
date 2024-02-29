namespace randomgombok
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {     
                int width = rand.Next(20, 51);
                int height = rand.Next(20, 51);

                int left = rand.Next(this.ClientSize.Width - width);
                int top = rand.Next(this.ClientSize.Height - height);

                int r = rand.Next(256);
                int g = rand.Next(256);
                int b = rand.Next(256);

                Button gomb = new Button();
                gomb.Width = width;
                gomb.Height = height;
                gomb.Left = left;
                gomb.Top = top;
                gomb.BackColor = Color.FromArgb(r, g, b);
                this.Controls.Add(gomb);
            }
        }
    }
}