using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace wfaContour
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> inputImage = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileDialog1.ShowDialog();

                if(res == DialogResult.OK)
                {
                    inputImage = new Image<Bgr, byte>(openFileDialog1.FileName);

                    pictureBox1.Image = inputImage.Bitmap;
                }
                else
                {
                    MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void найтиКонтурToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Image<Gray, byte> outputImage = inputImage.Convert<Gray, byte>().ThresholdBinary(new Gray(100), new Gray(255));

                VectorOfVectorOfPoint conturs = new VectorOfVectorOfPoint();

                Mat hierarchy = new Mat();

                CvInvoke.FindContours(outputImage, conturs, hierarchy, Emgu.CV.CvEnum.RetrType.Tree, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                CvInvoke.DrawContours(inputImage, conturs, -1, new MCvScalar(255, 0, 0), 3);

                pictureBox2.Image = inputImage.Bitmap;
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
