using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace task3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(aTextBox.Text, out double a) && double.TryParse(bTextBox.Text, out double b))
            {
                DrawGraph(a, b);
            }
            else
            {
                MessageBox.Show("Введите a и b.");
            }
        }

        private void DrawGraph(double a, double b)
        {
            canvas.Children.Clear();
            DrawAxes();

            Polyline polyline = new Polyline
            {
                Stroke = Brushes.Green
            };

            double step = 0.1;
            for (double x = -10; x <= 10; x += step)
            {
                double y = -x;
                polyline.Points.Add(new Point(50 * x + canvas.ActualWidth / 2, canvas.ActualHeight / 2 - 50 * y));
            }

            canvas.Children.Add(polyline);
        }

        private void DrawAxes()
        {
            Line xAxis = new Line
            {
                X1 = 0,
                Y1 = canvas.ActualHeight / 2,
                X2 = canvas.ActualWidth,
                Y2 = canvas.ActualHeight / 2,
                Stroke = Brushes.Black
            };

            Line yAxis = new Line
            {
                X1 = canvas.ActualWidth / 2,
                Y1 = 0,
                X2 = canvas.ActualWidth / 2,
                Y2 = canvas.ActualHeight,
                Stroke = Brushes.Black
            };

            canvas.Children.Add(xAxis);
            canvas.Children.Add(yAxis);
        }
    }
}
