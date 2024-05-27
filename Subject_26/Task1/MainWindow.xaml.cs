using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using Task1.Models;
using Task1.Services;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Map _map;
        public MainWindow()
        {
            InitializeComponent();
            _map = new Map("C:\\Users\\Вова\\Desktop\\Practice\\Subject_26\\Task1\\Map.xml");
            DisplayData();
        }

        private void AddRecord_Click(object sender, RoutedEventArgs e)
        {
            string countryName = countryNameTextBox.Text;
            string area = areaTextBox.Text;
            string population = populationTextBox.Text;

            if (!string.IsNullOrWhiteSpace(countryName) && !string.IsNullOrWhiteSpace(area) && !string.IsNullOrWhiteSpace(population))
            {
                try
                {
                    double areaValue = double.Parse(area);
                    int populationValue = int.Parse(population);

                    Country country = new Country(countryName, areaValue, populationValue);
                    _map.SaveCountry(country);

                    MessageBox.Show("Запись успешно добавлена в файл Карта.xml.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    DisplayData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при добавлении записи: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void DisplayData()
        {
            if (_map != null)
            {
                try
                {
                    XDocument doc = XDocument.Load(_map.FilePath);
                    string data = doc.ToString(); 

                    textInfo.Text = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при загрузке данных из файла: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}