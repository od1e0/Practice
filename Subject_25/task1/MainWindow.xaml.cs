using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace task1_2
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			buttonRun.Click += buttonRun_Click;
			buttinAbout.Click += buttinAbout_Click;
		}

		private void buttonRun_Click(object sender, RoutedEventArgs e)
		{
			string hello = "Hello";
			TextBoxEnterName.Text = $"{hello} {textboxName.Text}";
		}

		private void buttinAbout_Click(object sender, RoutedEventArgs e)
		{
			string info = $"О программе{this.Title}";
			Window1 aboutApp = new Window1(info);
			aboutApp.ShowDialog();
		}

		private void buttonClose_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
        }
    }
}
