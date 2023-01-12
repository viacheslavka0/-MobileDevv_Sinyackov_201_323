using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAGameQuiz
{
    public partial class Form1 : Form
    {

        Button[] but = new Button[12];
        int id;
        int counter;
        Form2 modal = new Form2();
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BringToFront(); //картинку на передний план
            button1.BringToFront();
            qPB1.Hide();
            qPB2.Hide();
            qPB3.Hide();

            qB1.Hide();
            qB2.Hide();
            qB3.Hide();
            qB4.Hide();

            label4.Text = $"Счет: {counter}";


        }

       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              pictureBox1.Hide(); //после нажатия прячем картинку и кнопку
              button1.Hide();



            

            int y = 10, x = 300;
            int buttonWidth = 180;
            int buttonHeight = 100;
            int price = 100;

            for (int k = 0; k < 9; k++)
            {
                but[k] = new Button();
                but[k].Tag = k; //даем кнопке тэг, чтобы потом использовать ее порядковый номер 
                but[k].Text = (price).ToString();
                but[k].Font = new Font(but[k].Font.FontFamily, 28);
                but[k].BackColor = Color.White;
                but[k].Location = new Point(x, y);
                but[k].Size = new Size(buttonWidth, buttonHeight);
                this.Controls.Add(but[k]);
                but[k].Click += Form1_Click;
                if ((k + 1) % 3 == 0)
                {
                    price = 0;
                    x = 300;
                    y += buttonHeight + 50;
                }
                else
                    x += buttonWidth + 30;
                    price+= 100;
            }

           
            





        }
        public void HideF()
        {
            for (int k = 0; k < 9; k++)
            {
                but[k].Hide();
            }

            label1.Hide();
            label2.Hide();
            label3.Hide();
        }

        private void Wrong_Click(object sender, EventArgs e)
        {
            counter--;
            label4.Text = $"Счет: {counter}";
            MessageBox.Show("Вы ответили неверно!");
            qPB1.Hide();
            qPB2.Hide();
            qPB3.Hide();

            qB1.Refresh();
            qB2.Refresh();
            qB3.Refresh();
            qB4.Refresh();

            qB1.Hide();
            qB2.Hide();
            qB3.Hide();
            qB4.Hide();

            for (int k = 0; k < 9; k++)
            {
                but[k].Show();
                
            }

            label1.Show();
            label2.Show();
            label3.Show();
        }

        private void Right_Click(object sender, EventArgs e)
        {
            counter++;
            label4.Text = $"Счет: {counter}";
            MessageBox.Show("Вы ответили верно!");
            qPB1.Hide();
            qPB2.Hide();
            qPB3.Hide();

            qB1.Refresh();
            qB2.Refresh();
            qB3.Refresh();
            qB4.Refresh();

            qB1.Hide();
            
            qB2.Hide();
            qB3.Hide();
            qB4.Hide();

            for (int k = 0; k < 9; k++)
            {
                but[k].Show();
            }

            label1.Show();
            label2.Show();
            label3.Show();



        }



        private void Form1_Click(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;
            id = pressedButton.Tag.GetHashCode();

            HideF();

            switch (id)
            {
                case 0:

                  qPB1.Show();
                  qPB2.Show();
                    qPB3.Show();

                    qB1.Show();
                    qB2.Show();
                    qB3.Show();
                    qB4.Show();

                    qPB1.Load(".\\img\\1.ЕЛКИ.jpg");
                  qPB2.Load(".\\img\\2. ЕЛКИ.jpg");
                  qPB3.Load(".\\img\\3.ЕЛКИ.jpg");

                    qB1.Text = "Ирония судьбы или с легким паром";
                    qB2.Text = "Елки";
                    qB3.Text = "Один дома";
                    qB4.Text = "Золушка";

                    qB2.Click += Right_Click;
                    qB1.Click += Wrong_Click;
                    qB3.Click += Wrong_Click;
                    qB4.Click += Wrong_Click;

                    but[0].Enabled = false;

                    
                    but[0].BackColor = Color.Gray;

                    
                    
                    break;

                case 1:

                    qPB1.Show();
                    qPB2.Show();
                    qPB3.Show();

                    qB1.Show();
                    qB2.Show();
                    qB3.Show();
                    qB4.Show();

                    qPB1.Load(".\\img\\1.Чарли и ШФ.jpg");
                    qPB2.Load(".\\img\\2Чарли.jpg");
                    qPB3.Load(".\\img\\3. Чарли.jpg");

                    qB1.Text = "Гринч - похититель Рождества";
                    qB4.Text = "Полярный экспресс";
                    qB2.Text = "Красавица и чудовище";
                    qB3.Text = "Чарли и Шоколадная фабрика";

                    qB4.Click += Wrong_Click;
                    qB1.Click += Wrong_Click;
                    qB3.Click += Wrong_Click;
                    qB2.Click += Right_Click;

                    but[1].Enabled = false;


                    but[1].BackColor = Color.Gray;



                    break;

                case 2:

                    qPB1.Show();
                    qPB2.Show();
                    qPB3.Show();

                    qB1.Show();
                    qB2.Show();
                    qB3.Show();
                    qB4.Show();

                    qPB1.Load(".\\img\\3. Хроники нарнии.jpg");
                    qPB2.Load(".\\img\\3. Хроники нарнии.png");
                    qPB3.Load(".\\img\\3.Хроники нарнии.jpg");

                    qB1.Text = "Новогодний переполох";
                    qB2.Text = "Любовь и голуби";
                    qB3.Text = "Гарии Поттер";
                    qB4.Text = "Хроники Нарнии";

                    qB2.Click += Wrong_Click;
                    qB1.Click += Wrong_Click;
                    qB3.Click += Wrong_Click;
                    qB4.Click += Right_Click;

                    but[2].Enabled = false;


                    but[2].BackColor = Color.Gray;
                    break;

                case 3:

                    
                    qPB2.Show();

                    

                    qB1.Show();
                    qB2.Show();
                    qB3.Show();
                    qB4.Show();

                    
                    qPB2.Load(".\\Кадры\\ГП.jpg");
                    

                    qB1.Text = "Гарии Поттер и Дары смерти";
                    qB2.Text = "Гарии Поттер и Тайная комната";
                    qB3.Text = "Гарии Поттер и Кубок Огня";
                    qB4.Text = "Гарии Поттер и Философский камень";

                    qB2.Click += Wrong_Click;
                    qB1.Click += Wrong_Click;
                    qB3.Click += Wrong_Click;
                    qB4.Click += Right_Click;

                    but[3].Enabled = false;


                    but[3].BackColor = Color.Gray;
                    break;

                case 4:


                    qPB2.Show();



                    qB1.Show();
                    qB2.Show();
                    qB3.Show();
                    qB4.Show();


                    qPB2.Load(".\\Кадры\\ОД.jpg");


                    qB1.Text = "Один Дома 2";
                    qB2.Text = "Один Дома 3";
                    qB3.Text = "Один Дома";
                    qB4.Text = "один Дома 4";

                    qB2.Click += Wrong_Click;
                    qB4.Click += Wrong_Click;
                    qB3.Click += Wrong_Click;
                    qB1.Click += Right_Click;

                    but[4].Enabled = false;


                    but[4].BackColor = Color.Gray;
                    break;


                case 5:


                    qPB2.Show();



                    qB1.Show();
                    qB2.Show();
                    qB3.Show();
                    qB4.Show();


                    qPB2.Load(".\\Кадры\\ГР.jpg");


                    qB1.Text = "Красавица и Чудовище";
                    qB2.Text = "Гринч - похититель Рождества";
                    qB3.Text = "Уэнсдей";
                    qB4.Text = "Семейка Аддамс";

                    qB1.Click += Wrong_Click;
                    qB4.Click += Wrong_Click;
                    qB3.Click += Wrong_Click;
                    qB2.Click += Right_Click;

                    but[5].Enabled = false;


                    but[5].BackColor = Color.Gray;
                    break;

                case 6:


                    qPB2.Show();



                    qB1.Show();
                    qB2.Show();
                    qB3.Show();
                    qB4.Show();


                    qPB2.Load(".\\корпуса\\автаз.jpg");


                    qB1.Text = "Автозаводская";
                    qB2.Text = "БС";
                    qB3.Text = "ПК";
                    qB4.Text = "Михалковская";

                    qB2.Click += Wrong_Click;
                    qB4.Click += Wrong_Click;
                    qB3.Click += Wrong_Click;
                    qB1.Click += Right_Click;

                    but[6].Enabled = false;


                    but[6].BackColor = Color.Gray;
                    break;

                case 7:


                    qPB2.Show();



                    qB1.Show();
                    qB2.Show();
                    qB3.Show();
                    qB4.Show();


                    qPB2.Load(".\\корпуса\\автаз.jpg");


                    qB1.Text = "Автозаводская";
                    qB2.Text = "БС";
                    qB3.Text = "ПК";
                    qB4.Text = "Михалковская";

                    qB2.Click += Wrong_Click;
                    qB4.Click += Wrong_Click;
                    qB3.Click += Wrong_Click;
                    qB1.Click += Right_Click;

                    but[6].Enabled = false;


                    but[6].BackColor = Color.Gray;
                    break;
            }
            


        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
