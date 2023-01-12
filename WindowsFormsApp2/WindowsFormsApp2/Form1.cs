using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = $"Очки: {counter}";
        }

        public struct Element
        {
            public Label label;
            public PictureBox image;
            public string NeededChar;
            public Form1 FormLink;

            public void Recreate()
            {
                if (image == null)
                {
                    // Создаём пикчу
                }
                if (label == null)
                {
                    label = new Label();
                    label.Left = r.Next(5, FormLink.Width - 5);
                    FormLink.Controls.Add(label);
                    
                    // Создаём текст
                }
                //image.Top = 5;
                label.Top = 5;
                label.Text = NeededChar = CHARS[r.Next(0, CHARS.Length)].ToString();
            }

            public Element(Form1 link)
            {
                this.label = null;
                this.image = null;
                NeededChar = "";
                FormLink = link;
            }
        }
        static string CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static int COUNT = 5;
        int[] Timers = new int[COUNT];
        int time_=100;
        int counter = 0;
        Element[] Elements = new Element[COUNT];
        
        static Random r = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < COUNT; i++)
            {

                if (Timers[i] > 0)
                {
                    
                    label1.Text = $"Оставшееся время: {time_}";
                    Timers[i]--;
                    if (Timers[i] == 0) Elements[i].Recreate();
                }
                else
                {
                    //Elements[i].image.Top++;
                    Elements[i].label.Top += 5;
                    if (Elements[i].label.Top > 300)
                    {
                        counter--;
                        label2.Text = $"Очки: {counter}";
                        Elements[i].Recreate();
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var s = e.KeyCode.ToString();
            for (int i = 0; i < COUNT; i++)
            {
                if (Timers[i] == 0 && Elements[i].NeededChar == s)
                {
                    counter++;

                    label2.Text = $"Очки: {counter}";
                    Elements[i].Recreate();
                }
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            for (int i = 0; i < COUNT; i++)
            {
                Timers[i] = r.Next(1, 25);
                Elements[i] = new Element(this);
            }
        }
    }
}
