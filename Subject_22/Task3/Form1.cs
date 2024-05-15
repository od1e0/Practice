namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text); 
            double b = double.Parse(textBox2.Text);
            double x0 = -4;
            double xk = -6.2;
            double dx = -0.2;

            for (double x = x0; x >= xk; x += dx)
            {
                double y = x + Math.Sqrt(Math.Abs(Math.Pow(x, 3) + a - b * Math.Exp(x)));
                listBox1.Items.Add($"x = {x}, y = {y}");
            }
        }
    }
}
