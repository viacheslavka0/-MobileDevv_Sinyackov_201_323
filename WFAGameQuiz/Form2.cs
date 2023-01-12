using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFAGameQuiz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       
        public void Form2_Load(object sender, EventArgs e)
        {

            //string path = "C:\\Users\\79534\\Desktop\\ПОЛИТЕХ\\Моб.разработка\\WFAGameQuiz\\Resources\\1.ЕЛКИ.jpg";
           

            qPictBox1.Load(".\\img\\1.ЕЛКИ.jpg");

        }
    }
}
