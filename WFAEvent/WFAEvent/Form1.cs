namespace WFAEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button2.Click += Button2_Click;

            button3.Click += delegate
            {
                MessageBox.Show("способ3");
            };

            button4.Click += (s, e) => MessageBox.Show("способ4");

        }


        private void Button2_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("способ2");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("способ1");

        }
    }
}