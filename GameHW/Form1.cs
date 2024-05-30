namespace GameHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseClick += Form1_MouseClick;
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            Graphics g = this.CreateGraphics();
            Color color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            int radius = r.Next(20, 100);

            int x = e.X - radius;
            int y = e.Y - radius;

            g.FillEllipse(new SolidBrush(color), x, y, radius, radius);
            g.Dispose();
        }
    }
}
