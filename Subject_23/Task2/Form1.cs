using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Task2
{
    public partial class Form1 : Form
    {
        private Chart chart1;
        private Button buttonCalc;
        private TextBox textBoxXmin;
        private TextBox textBoxXmax;
        private TextBox textBoxStep;

        public Form1()
        {
            InitializeComponent();
            InitializeChart();
            InitializeControls();
        }

        private void InitializeChart()
        {
            chart1 = new Chart();
            chart1.Dock = DockStyle.Top;
            chart1.Height = 400;

            ChartArea chartArea = new ChartArea("MainArea");
            chart1.ChartAreas.Add(chartArea);

            Series series1 = new Series("c(x)");
            series1.ChartType = SeriesChartType.Spline;
            series1.BorderWidth = 2;
            series1.Color = System.Drawing.Color.Blue;
            chart1.Series.Add(series1);

            this.Controls.Add(chart1);
        }

        private void InitializeControls()
        {
            textBoxXmin = new TextBox { Dock = DockStyle.Top, Text = "Введите Xmin" };
            textBoxXmax = new TextBox { Dock = DockStyle.Top, Text = "Введите Xmax" };
            textBoxStep = new TextBox { Dock = DockStyle.Top, Text = "Введите шаг" };

            buttonCalc = new Button
            {
                Text = "Расчёт",
                Dock = DockStyle.Bottom
            };
            buttonCalc.Click += new EventHandler(buttonCalc_Click);

            this.Controls.Add(textBoxStep);
            this.Controls.Add(textBoxXmax);
            this.Controls.Add(textBoxXmin);
            this.Controls.Add(buttonCalc);
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double Xmin = double.Parse(textBoxXmin.Text);
                double Xmax = double.Parse(textBoxXmax.Text);
                double Step = double.Parse(textBoxStep.Text);

                UpdateChart(Xmin, Xmax, Step);
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите правильные числовые значения.");
            }
        }

        private double CalculateFunction(double x, double y, double z)
        {
            return Math.Pow(2, Math.Pow(y, x)) + Math.Pow(Math.Pow(3, x), y) - (y * (Math.Atan(z) - Math.PI / 6)) / (Math.Abs(x) + 1 / (y * y + 1));
        }

        private void UpdateChart(double Xmin, double Xmax, double Step)
        {
            double y = 0.827;
            double z = 25.001;

            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;

            double[] xValues = new double[count];
            double[] cValues = new double[count];

            for (int i = 0; i < count; i++)
            {
                double x = Xmin + Step * i;
                xValues[i] = x;
                cValues[i] = CalculateFunction(x, y, z);
            }

            chart1.Series["c(x)"].Points.Clear();

            chart1.Series["c(x)"].Points.DataBindXY(xValues, cValues);
        }
    }
}
