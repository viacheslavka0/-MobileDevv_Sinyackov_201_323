namespace WFAEvent3
{
    public partial class Form1 : Form
    {
        private Random rnd = new();
        public Form1()
        {
            InitializeComponent();

            this.MouseDown += Form1_MouseDown;
        }

        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Label la = new Label();
                //var la = new Label();
                Label la = new();
                la.Location = e.Location;
                la.Text = $"{e.X},{e.Y}";
                la.BackColor = Color.LightGreen;
                this.Controls.Add(la);
                la.AutoSize = true;
            }
            if(e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < 50; i++)
                {
                    Label la = new();
                    la.Location = new Point(
                        rnd.Next(this.ClientSize.Width),
                        rnd.Next(this.ClientSize.Height));
                    la.Text = $"{la.Location.X},{la.Location.Y}";
                    la.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    this.Controls.Add(la);
                    la.AutoSize = true;
                }
            }
            if(e.Button == MouseButtons.Middle)
            {
                this.Controls.Clear();
            }
        }
    }
}