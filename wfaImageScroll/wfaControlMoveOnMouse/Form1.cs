using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaControlMoveOnMouse
{
    public partial class Form1 : Form
    {
        private Point startPoint;

        public Form1()
        {
            InitializeComponent();

            panel1.MouseDown += All_MouseDown; ;
            panel2.MouseDown += All_MouseDown; ;
            pictureBox1.MouseDown += All_MouseDown; ;

            panel1.MouseMove += All_MouseMove;
            panel2.MouseMove += All_MouseMove;
            pictureBox1.MouseMove += All_MouseMove;

            panel1.MouseWheel += All_MouseWheel;
            panel2.MouseWheel += All_MouseWheel;
            pictureBox1.MouseWheel += All_MouseWheel;
        }

        private void All_MouseWheel(object? sender, MouseEventArgs e)
        {
            int xDelta = e.Delta > 0 ? 2 : -2;
            if (sender is Control c)
            {
                c.Location = new Point(
                        c.Location.X - xDelta,
                        c.Location.Y - xDelta
                    );
                c.Width += xDelta * 2;
                c.Height += xDelta * 2;

            }
        }

        private void All_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (sender is Control c)
                {
                    c.Location = new Point(
                        c.Location.X + e.X - startPoint.X,
                        c.Location.Y + e.Y - startPoint.Y
                        );
                }
            }
        }

        private void All_MouseDown(object? sender, MouseEventArgs e)
        {
            startPoint = e.Location;

            if (sender is Control c)
            {
                c.BringToFront(); // перенос на передний план
            }
        }
    }
}
