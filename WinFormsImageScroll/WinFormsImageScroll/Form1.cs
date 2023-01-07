using System.Windows.Forms;

namespace WinFormsImageScroll
{
    public partial class Form1 : Form
    {
        private Bitmap p;
        private Point startPoint;
        private Point curPoint = new Point(0, 0);
        private Rectangle rect;

        public static int NumImage { get; private set; } = 0;
        public int ZoomDel { get; private set; } = 100;

        public Form1()
        {
            InitializeComponent();

            NextImage();

           
            pxImage.Size = new Size((p.Width * ZoomDel), (p.Height * ZoomDel));

            pxImage.CreateGraphics().DrawImage(p, 0, 0, pxImage.Width, pxImage.Height);
            pxImage.Paint += (s, e) => e.Graphics.DrawImage(p, curPoint);
            // public void DrawImage(Image image, int x, int y, Rectangle srcRect, GraphicsUnit srcUnit);
            pxImage.MouseDown += (s, e) => startPoint = e.Location;
            pxImage.MouseMove += PxImage_MouseMove;
            pxImage.MouseWheel += PxImage_MouseWheel;

            this.KeyDown += Form1_KeyDown;
            this.Text += $" : F1 - —ледующа€ картинка";

        }

        private void NextImage()
        {
            NumImage = ++NumImage % 2;
            switch (NumImage)
            {
                case 0:
                    p = new Bitmap(Properties.Resources.image1);
                    break;
                case 1:
                    p = new Bitmap(Properties.Resources.image2);
                    break;
            }
            pxImage.Invalidate();
            RefresStatus();
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            
            switch(e.KeyCode)
            {
                case Keys.F1:
                    NextImage();
                    break;
            }

        }

        private void PxImage_MouseWheel(object? sender, MouseEventArgs e)
        {

            ZoomDel += e.Delta < 0 ? 2 : -2;
            //запрогать зум
            //e.Graphics.DrawImage(p, curPoint); на основе этого

           

            pxImage.Invalidate();
            RefresStatus();
        }

        private void PxImage_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                curPoint.X += e.X - startPoint.X;
                curPoint.Y += e.Y - startPoint.Y;
                startPoint = e.Location;
                pxImage.Invalidate();
            }

            RefresStatus();

        }

        private void RefresStatus()
        {
            LaStatus.Text = $" NumImage = {NumImage}, startPoint = {startPoint}, curPoint = {curPoint}, ZoomDel = {ZoomDel}";
        }
    }
}