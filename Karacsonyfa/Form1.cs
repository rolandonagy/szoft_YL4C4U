namespace Karacsonyfa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int m = 20;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int s = 0; s < 10; s++)
            {
                for (int o = 0; o < s+1; o++)
                {
                    Button b = new Button();
                    b.Height = m;
                    b.Width = m;
                    b.Left = ClientRectangle.Width/2 - s*(b.Width/2) + o*b.Width;
                    b.Top = (s*m);
                    Controls.Add(b);
                }
            }
        }
    }
}