namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text) * Math.Pow(10, -2);
            double z = double.Parse(textBox3.Text) * Math.Pow(10, 3);
            double h = (Math.Pow(x, (y + 1)) + Math.Pow(Math.E, (y - 1))) / (1 + x * Math.Abs(y - Math.Tan(z))) * (1 + Math.Abs(y - x)) + Math.Pow(Math.Abs(y - x), 2) / 2 - Math.Pow(Math.Abs(y - x), 3) / 3;

            textBox4.Text = "h = " + h.ToString();
        }
    }
}
