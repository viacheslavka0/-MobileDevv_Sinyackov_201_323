using System.Windows.Forms;

namespace wfaPaint
{
    public partial class Form1 : Form
    {
        private enum MyDrawMode
        {
            Pencil,
            Line,
            Ellipse,
            Rectangle,
            Triangle,
            Arrow,
            Hexagon
        }

        private Bitmap b;
        private Graphics g;
        private Point startMouseDown;
        private Bitmap bb;
        private Pen myPen;
        private MyDrawMode myDrawMode = MyDrawMode.Pencil;
        private bool isGetPixel = false;

        public Form1()
        {
            InitializeComponent();

            b = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            myPen = new Pen(pxBlue.BackColor, 10);
            myPen.StartCap = myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            pxBlue.Click += (s, e) => myPen.Color = pxBlue.BackColor;
            pxRed.Click += (s, e) => myPen.Color = pxRed.BackColor;
            pxYellow.Click += (s, e) => myPen.Color = pxYellow.BackColor;
            pxGreen.Click += (s, e) => myPen.Color = pxGreen.BackColor;
            pxBlack.Click += (s, e) => myPen.Color = pxBlack.BackColor;

            trPenWidth.Value = Convert.ToInt32(myPen.Width);
            trPenWidth.ValueChanged += (s, e) => myPen.Width = trPenWidth.Value;

            pxImage.MouseDown += PxImage_MouseDown;
            pxImage.MouseMove += PxImage_MouseMove;
            pxImage.MouseUp += PxImage_MouseUp;
            pxImage.Paint += (s, e) => e.Graphics.DrawImage(b, 0, 0);

            buImageClear.Click += buImageClear_Click;
            buImgeLoadFile.Click += buImageLoadFile_Click;
            buImageSaveToFile.Click += buImageSaveToFile_Click;
            buImageSaveToClipboard.Click += (s, e) => Clipboard.SetImage(b);
            buCutOut.Click += (s, e) =>
            {
                Clipboard.SetImage(b);

                g.Clear(DefaultBackColor);
                pxImage.Invalidate();
            };

            buDrawPencil.Click += (s, e) => myDrawMode = MyDrawMode.Pencil;
            buDrawLine.Click += (s, e) => myDrawMode = MyDrawMode.Line;
            buDrawEllipse.Click += (s, e) => myDrawMode = MyDrawMode.Ellipse;
            buDrawRectangle.Click += (s, e) => myDrawMode = MyDrawMode.Rectangle;
            buDrawTrianlge.Click += (s, e) => myDrawMode = MyDrawMode.Triangle;
            buDrawArrow.Click += (s, e) => myDrawMode = MyDrawMode.Arrow;
            buDrawHexagon.Click += (s, e) => myDrawMode = MyDrawMode.Hexagon;
        }

        private void buImageSaveToFile_Click(object? sender, EventArgs e)
        {
            SaveFileDialog dialog = new();
            dialog.Filter = "Image Files(*.JPG)|*.JPG";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                b.Save(dialog.FileName);
                //b.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void buImageLoadFile_Click(object? sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                g.Clear(DefaultBackColor);
                g.DrawImage(Bitmap.FromFile(dialog.FileName), 0, 0);
                pxImage.Invalidate();
            }
        }

        private void buImageClear_Click(object? sender, EventArgs e)
        {
           g.Clear(DefaultBackColor);
            pxImage.Invalidate();
        }

        private void PxImage_MouseUp(object? sender, MouseEventArgs e)
        {
            //
        }

        private void PxImage_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                switch (myDrawMode)
                {
                    case MyDrawMode.Pencil:
                        g.DrawLine(myPen, startMouseDown, e.Location);
                        startMouseDown = e.Location;
                        break;
                    case MyDrawMode.Line:
                        RestoreBitmap();
                        g.DrawLine(myPen, startMouseDown, e.Location);
                        break;
                    case MyDrawMode.Ellipse:
                        RestoreBitmap();
                        if (ckFillMode.Checked)
                        {
                            g.FillEllipse(new SolidBrush(myPen.Color),
                               new Rectangle(startMouseDown.X, startMouseDown.Y,
                               e.X - startMouseDown.X, e.Y - startMouseDown.Y));
                        }
                        else
                        {
                            g.DrawEllipse(myPen,
                                new Rectangle(startMouseDown.X, startMouseDown.Y,
                                e.X - startMouseDown.X, e.Y - startMouseDown.Y));
                        }
                        break;
                    case MyDrawMode.Rectangle:
                        RestoreBitmap();
                        if (ckFillMode.Checked)
                        {
                            g.FillRectangle(new SolidBrush(myPen.Color),
                               new Rectangle(startMouseDown.X, startMouseDown.Y,
                               e.X - startMouseDown.X, e.Y - startMouseDown.Y));
                        }
                        else
                        {
                            g.DrawRectangle(myPen,
                                new Rectangle(startMouseDown.X, startMouseDown.Y,
                                e.X - startMouseDown.X, e.Y - startMouseDown.Y));
                        }
                        break;
                    case MyDrawMode.Triangle:
                        RestoreBitmap();
                        if (ckFillMode.Checked)
                        {
                            g.FillTriangle(new SolidBrush(myPen.Color), new Rectangle(startMouseDown.X, startMouseDown.Y,
                                e.X - startMouseDown.X, e.Y - startMouseDown.Y));
                        }
                        else
                        {
                            g.DrawTriangle(myPen, new Rectangle(startMouseDown.X, startMouseDown.Y,
                                e.X - startMouseDown.X, e.Y - startMouseDown.Y));
                        }
                        break;
                    case MyDrawMode.Arrow:
                        RestoreBitmap();
                        if (ckFillMode.Checked)
                        {
                            g.FillArrow(new SolidBrush(myPen.Color), new Rectangle(startMouseDown.X, startMouseDown.Y,
                                e.X - startMouseDown.X, e.Y - startMouseDown.Y));
                        }
                        else
                        {
                            g.DrawArrow(myPen, new Rectangle(startMouseDown.X, startMouseDown.Y,
                                e.X - startMouseDown.X, e.Y - startMouseDown.Y));
                        }
                        break;
                    case MyDrawMode.Hexagon:
                        RestoreBitmap();
                        if (ckFillMode.Checked)
                        {
                            g.FillHexagon(new SolidBrush(myPen.Color), new Rectangle(startMouseDown.X, startMouseDown.Y,
                                e.X - startMouseDown.X, e.Y - startMouseDown.Y));
                        }
                        else
                        {
                            g.DrawHexagon(myPen, new Rectangle(startMouseDown.X, startMouseDown.Y,
                                e.X - startMouseDown.X, e.Y - startMouseDown.Y));
                        }
                        break;
                    default:
                        break;
                }


                pxImage.Invalidate();
            }
        }

        private void RestoreBitmap()
        {
            g.Dispose();
            b.Dispose();
            b = (Bitmap)bb.Clone();
            g = Graphics.FromImage(b);
        }

        private void PxImage_MouseDown(object? sender, MouseEventArgs e)
        {
            startMouseDown = e.Location;
            bb = (Bitmap)b.Clone();

            if (isGetPixel)
            {
                myPen.Color = b.GetPixel(e.X, e.Y);

                isGetPixel = false;
            }
        }

        private void GetPixel(object sender, EventArgs e)
        {
            isGetPixel = true;
        }
    }

    
}