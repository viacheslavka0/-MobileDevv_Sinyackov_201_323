namespace WinFormPaint
{
    public partial class Form1 : Form
    {
        private Bitmap b;
        private Graphics g;
        private Point startMouseDown;
        private Bitmap bb;
        private Pen MyPen;
        private MyDrawMode myDrawMode = MyDrawMode.Pencil;

        public Form1()
        {
            InitializeComponent();



            b = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            g = Graphics.FromImage(b);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            MyPen = new Pen(pxBlue.BackColor, 10);

            MyPen.StartCap = MyPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            
            

            pxBlue.Click += (s, e) => MyPen.Color = pxBlue.BackColor;
            pxRed.Click += (s, e) => MyPen.Color = pxRed.BackColor;
            pxYellow.Click += (s, e) => MyPen.Color = pxYellow.BackColor;
            pxGreen.Click += (s, e) => MyPen.Color = pxGreen.BackColor;
            pxBlack.Click += (s, e) => MyPen.Color = pxBlack.BackColor;

            

            trPenWidth.Value = Convert.ToInt32(MyPen.Width);

            trPenWidth.ValueChanged += (s, e) => MyPen.Width = trPenWidth.Value;



         

            pxImage.MouseDown += PxImage_MouseDown;
            pxImage.MouseMove += PxImage_MouseMove;
            pxImage.MouseUp += PxImage_MouseUp;

            pxImage.Paint += (s, e) => e.Graphics.DrawImage(b, 0, 0);

            buImageClear.Click += BuImageClear_Click;
            buImageLoadFromFile.Click += BuImageLoadFromFile_Click;
            buImageSaveTo.Click += BuImageSaveTo_Click;
            buImageSaveBuffer.Click += (s, e) => Clipboard.SetImage(b);

            buDrawPencil.Click += (s,e) => myDrawMode = MyDrawMode.Pencil;
            buDrawLine.Click += (s,e) => myDrawMode = MyDrawMode.Line;
            buDrawEllipse.Click += (s,e) => myDrawMode = MyDrawMode.Ellipse;
            buDrawRectangle.Click += (s,e) => myDrawMode = MyDrawMode.Rectangle;
            buDrawTriangle.Click += (s,e) => myDrawMode = MyDrawMode.Triangle;

        }

       

        private void BuImageSaveTo_Click(object? sender, EventArgs e)
        {
           SaveFileDialog Dialog = new SaveFileDialog();
            Dialog.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                b.Save(Dialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
            pxImage.Invalidate();
        }

        private void BuImageLoadFromFile_Click(object? sender, EventArgs e)
        {
            
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";


            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                g.DrawImage(Bitmap.FromFile(Dialog.FileName), 0, 0);
            }
            pxImage.Invalidate();

        }

        private void BuImageClear_Click(object? sender, EventArgs e)
        {
            
            g.Clear(DefaultBackColor);
            pxImage.Invalidate();
        }

        private void PxImage_MouseUp(object? sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void PxImage_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // g.DrawLine(MyPen, startMouseDown, e.Location);
                // startMouseDown = e.Location;


                switch (myDrawMode)
                {
                    case MyDrawMode.Pencil:
                       g.DrawLine(MyPen, startMouseDown, e.Location);
                        startMouseDown = e.Location;
                        break;
                    case MyDrawMode.Line:
                        RestoreBitmap(e);
                        g.DrawLine(MyPen, startMouseDown, e.Location);

                        break;
                    case MyDrawMode.Ellipse:

                        RestoreBitmap(e);

                        if (ckFillMode.Checked)
                        {
                            g.FillEllipse(new SolidBrush(MyPen.Color),
                                new Rectangle (startMouseDown.X, startMouseDown.Y,
                            e.X - startMouseDown.X, e.Y - startMouseDown.Y));
                                
                        }
                        else
                        { 
                        g.DrawEllipse(MyPen,
                            new Rectangle(startMouseDown.X, startMouseDown.Y,
                            e.X - startMouseDown.X, e.Y - startMouseDown.Y));
                        }

                        break;
                    case MyDrawMode.Rectangle:
                        break;
                    case MyDrawMode.Triangle:
                        break;
                    default:
                        break;
                }




                pxImage.Invalidate();
            }
        }

        private void RestoreBitmap(MouseEventArgs e)
        {
            g.Dispose();
            b = (Bitmap)bb.Clone();
            g = Graphics.FromImage(b);
           
        }

        private void PxImage_MouseDown(object? sender, MouseEventArgs e)
        {
            startMouseDown = e.Location;

            bb =(Bitmap) b.Clone();

        }
    }

    enum MyDrawMode
    {
        Pencil,
        Line,
        Ellipse,
        Rectangle,
        Triangle
    }
}

