namespace WinFormSearchCity
{
    public partial class Form1 : Form
    {
        private string[] cities;

        public Form1()
        {
            InitializeComponent();

            cities = Properties.Resources.goroda.Split('\n');

            edSearch.TextChanged += TextBox1_TextChanged;


        }

        private void TextBox1_TextChanged(object? sender, EventArgs e)
        {

            Text = $"{Application.ProductName}: {edSearch.Text}";

            var r = cities.Where(x => x.ToUpper().Contains(edSearch.Text.ToUpper()))
                .Where(v => v != "")
                .Where(v => !v.Contains("Список городов России в формате *.txt - текстовый файл."))
                .OrderBy(v => v)
                .Take(100)
                .ToArray();

            edResult.Text = String.Join(Environment.NewLine, r);


        }
    }
}