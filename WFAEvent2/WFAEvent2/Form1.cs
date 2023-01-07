namespace WFAEvent2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyDown += Form1_KeyDown;
        }
        
        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                MessageBox.Show("Нажата клавиша Enter");


            switch (e.KeyCode)
            {
                case Keys.Left:
                    label2.Text = "Left";
                    break;
                case Keys.Right:
                    label2.Text = "Right";
                    break;
                case Keys.Space:
                    if (e.Shift)
                    {
                        label2.Text = "Shift + Space ";
                    }
                    else
                    {
                        label2.Text = "Space";

                    }
                    break;
                default:
                    label2.Text = $"Другая клавиша = {e.KeyCode}";
                    break;
            }
        }

    }
}