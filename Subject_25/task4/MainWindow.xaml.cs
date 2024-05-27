using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace task4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random;

        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            CreateNewButton();
        }

        private void CreateNewButton()
        {
            Button newButton = new Button
            {
                Content = "Слови меня.",
                Width = 100,
                Height = 50,
                Margin = new Thickness(10)
            };

            newButton.MouseEnter += Button_MouseEnter;
            newButton.Click += InitialButton_Click;

            double left = random.NextDouble() * (MainGrid.ActualWidth - newButton.Width);
            double top = random.NextDouble() * (MainGrid.ActualHeight - newButton.Height);

            newButton.Margin = new Thickness(left, top, 0, 0);
            newButton.HorizontalAlignment = HorizontalAlignment.Left;
            newButton.VerticalAlignment = VerticalAlignment.Top;

            MainGrid.Children.Add(newButton);
        }

        private void InitialButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                MainGrid.Children.Remove(button);
            }
        }
    }
}
