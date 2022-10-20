namespace WFGraphicsSinCos
{
    public partial class Form1 : Form
    {
        private const int DOT_WIDTH = 2;
        private const int DOT_HEIGHT = 2;


        public Form1()
        {
            InitializeComponent();
                    
            this.BackgroundImageLayout = ImageLayout.None;


            DrawAll();
            this.Resize += (s,e) => DrawAll();

            this.Text += " : (sin - красный ,  cos - Синий, Tan - зеленый) ";


        }

        private void DrawAll()
        {
            var b = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            var g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            var grShifrY = b.Height / 2;
            var grShifrX = b.Width / 2;
            var grCountWave = 5; //кол-во волн
            var grHeight = grShifrY*0.9; 
            var grWidthPI = Math.PI / (b.Width - 1); // ширина отрезка Пи в радианах
            //рисуем ось Х
            g.DrawLine(new Pen(Color.Black), 0, grShifrY, b.Width, grShifrY);

            for (int i = 1; i < grCountWave; i++)
            {
                var xPoint = b.Width / grCountWave * i;
                g.DrawLine(Pens.Black, xPoint, grShifrY - 5, xPoint, grShifrY + 15);
                g.DrawString($" {i} pi", new Font("", 10), new SolidBrush(Color.Black), xPoint - 10, grShifrY + 5);
                    }
            //ось Y
            g.DrawLine(new Pen(Color.Black), 0, 0, 0, b.Height);

            //sin
            float x;
            float y;
            for (int i = 0; i < b.Width; i++)
            {
                x = i;
                y = (float)(grHeight * (-Math.Sin(i * grCountWave * grWidthPI))) + grShifrY;
                g.FillEllipse(new SolidBrush(Color.Red), x - DOT_WIDTH / 2, y - DOT_HEIGHT / 2, DOT_WIDTH, DOT_HEIGHT);

                //cos
               
              
                y = (float)(grHeight * (-Math.Cos(i * grCountWave * grWidthPI))) + grShifrY;
                g.FillEllipse(new SolidBrush(Color.Green), x - DOT_WIDTH / 2, y - DOT_HEIGHT / 2, DOT_WIDTH, DOT_HEIGHT);

                //tan
                y = (float)(grHeight * (-Math.Tan(i * grCountWave * grWidthPI))) + grShifrY;
                if (y > 0 && y < b.Height)
                {
                    
                    g.FillEllipse(new SolidBrush(Color.Blue), x - DOT_WIDTH / 2, y - DOT_HEIGHT / 2, DOT_WIDTH, DOT_HEIGHT);
                }
            }






            this.BackgroundImage = (Bitmap)b.Clone();


        }
    }
}