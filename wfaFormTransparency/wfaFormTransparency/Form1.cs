namespace wfaFormTransparency
{
    public partial class Form1 : Form
    {
        private Point startPoint;

        public Form1()
        {
            InitializeComponent();

            buClose.Click += (s, e) => Close();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = this.BackColor;

            this.MouseDown += (s, e) => startPoint = e.Location;
            this.MouseMove += Form1_MouseMove;
        }

        private void Form1_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                    this.Location.X + e.X - startPoint.X,
                    this.Location.Y + e.Y - startPoint.Y);
            }
        }
    }
}