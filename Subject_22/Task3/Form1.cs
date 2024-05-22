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
            if (!TryParseInputs(out double a, out double b))
            {
                MessageBox.Show("Пожалуйста, введите числа во все поля ввода.", "Неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double x0 = -4;
            double xk = -6.2;
            double dx = -0.2;

            CalculateAndDisplayResults(a, b, x0, xk, dx);
        }

        private bool TryParseInputs(out double a, out double b)
        {
            bool isAValid = double.TryParse(textBox1.Text, out a);
            bool isBValid = double.TryParse(textBox2.Text, out b);

            return isAValid && isBValid;
        }

        private void CalculateAndDisplayResults(double a, double b, double x0, double xk, double dx)
        {
            listBox1.Items.Clear(); 

            for (double x = x0; x >= xk; x += dx)
            {
                double y = CalculateY(a, b, x);
                listBox1.Items.Add($"x = {x}, y = {y}");
            }
        }

        private double CalculateY(double a, double b, double x)
        {
            return x + Math.Sqrt(Math.Abs(Math.Pow(x, 3) + a - b * Math.Exp(x)));
        }

    }
}
