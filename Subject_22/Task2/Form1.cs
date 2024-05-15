namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double z = double.Parse(textBox3.Text);

            Func<double, double> f;
            if (radioButton1.Checked)
            {
                f = Math.Sinh;
            }
            else if (radioButton2.Checked)
            {
                f = x => Math.Pow(x, 2);
            }
            else
            {
                f = Math.Exp;
            }

            double m = (Math.Max(f(x), Math.Max(y, z))) / Math.Min(f(x), y) + 5;

            textBox4.Text = "m = " + m.ToString();
        }
    }
}
