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
            if (!TryParseInputs(out double x, out double y, out double z))
            {
                MessageBox.Show("Пожалуйста, введите числа во все поля ввода.", "Неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Func<double, double> f = GetFunction();
            double result = CalculateResult(x, y, z, f);

            textBox4.Text = "m = " + result.ToString();
        }

        private bool TryParseInputs(out double x, out double y, out double z)
        {
            bool isXValid = double.TryParse(textBox1.Text, out x);
            bool isYValid = double.TryParse(textBox2.Text, out y);
            bool isZValid = double.TryParse(textBox3.Text, out z);

            return isXValid && isYValid && isZValid;
        }

        private Func<double, double> GetFunction()
        {
            if (radioButton1.Checked)
            {
                return Math.Sinh;
            }
            else if (radioButton2.Checked)
            {
                return x => Math.Pow(x, 2);
            }
            else
            {
                return Math.Exp;
            }
        }

        private double CalculateResult(double x, double y, double z, Func<double, double> f)
        {
            double fX = f(x);
            double maxVal = Math.Max(fX, Math.Max(y, z));
            double minVal = Math.Min(fX, y);

            return (maxVal / minVal) + 5;
        }

    }
}
