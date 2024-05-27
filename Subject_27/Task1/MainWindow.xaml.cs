using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Extensions.Logging;
using System.Xml.Linq;
using Task1.Models;
using Task1.Services;
using Microsoft.Win32;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Map _mapService;
        private readonly ILogger<MainWindow> _logger;
        private string _xmlFilePath;
        public MainWindow()
        {
            InitializeComponent();
            _logger = LoggerFactory.Create(builder => builder.SetMinimumLevel(LogLevel.Information)).CreateLogger<MainWindow>();
            _mapService = new Map(_xmlFilePath);
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
                    _mapService.SaveCountry(country);
                    PrintCountries(_mapService.LoadCountries());

                    MessageBox.Show("Запись успешно добавлена в файл Карта.xml.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
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

        private void SearchRecord_Click(object sender, RoutedEventArgs e)
        {
            var countries = _mapService.LoadCountries();
            var country = countries.FirstOrDefault(c => c.Name == searchTextBox.Text);
            PrintCountry(country);
        }

        private void PrintCountry(Country country)
        {
            string content = "=====Страна=====\n";
            content += country?.ToXElement().ToString() ?? "Страна не найдена";
            textInfo.Text = content;
        }

        private void PrintCountries(List<Country> countries)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=====Страны=====");
            sb.AppendLine();

            foreach (var country in countries)
            {
                sb.AppendLine(country.ToString());
            }

            string content = sb.ToString();

            textInfo.Text = content;

            treeViewXMLFileContent.Items.Clear();
            foreach (var country in countries)
            {
                TreeViewItem item = new TreeViewItem { Header = country.Name };
                item.Items.Add($"Площадь: {country.Area}");
                item.Items.Add($"Численность населения: {country.Population}");
                treeViewXMLFileContent.Items.Add(item);
            }

            listBoxXMLFileContent.Items.Clear();
            foreach (var country in countries)
            {
                listBoxXMLFileContent.Items.Add($"{country.Name}: {country.Area} кв. км, {country.Population} чел.");
            }
        }

        private void OpenRecord_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Directory.GetParent(AppContext.BaseDirectory)
                .Parent
                .Parent
                .FullName;
            dialog.DefaultExt = ".xml";
            dialog.Filter = "xml documents (.xml)|*.xml";
            var result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                _xmlFilePath = dialog.FileName;
                _mapService = new Map(_xmlFilePath);
                PrintCountries(_mapService.LoadCountries());
            }
        }

        private void DeleteRecord_Click(object sender, RoutedEventArgs e)
        {
            string nameToDelete = searchTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(nameToDelete))
            {
                MessageBox.Show("Введите название страны для удаления.");
                return;
            }

            try
            {
                var countries = _mapService.LoadCountries();
                var countryToDelete = countries.FirstOrDefault(c => c.Name == nameToDelete);
                if (countryToDelete != null)
                {
                    countries.Remove(countryToDelete);
                    SaveAllCountries(countries);
                    PrintCountries(_mapService.LoadCountries());
                    MessageBox.Show("Страна успешно удалена.");
                }
                else
                {
                    MessageBox.Show("Страна не найдена.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении страны: {ex.Message}");
            }
        }

        private void SaveAllCountries(List<Country> countries)
        {
            try
            {
                XDocument doc = new XDocument(new XElement("Map"));

                foreach (var country in countries)
                {
                    doc.Root.Add(country.ToXElement());
                }

                doc.Save(_xmlFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении стран: {ex.Message}");
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton == null) return;

            textInfo.Visibility = Visibility.Collapsed;
            treeViewXMLFileContent.Visibility = Visibility.Collapsed;
            listBoxXMLFileContent.Visibility = Visibility.Collapsed;

            switch (radioButton.Name)
            {
                case "listBlock":
                    textInfo.Visibility = Visibility.Visible;
                    break;
                case "treeView":
                    treeViewXMLFileContent.Visibility = Visibility.Visible;
                    break;
                case "listBox":
                    listBoxXMLFileContent.Visibility = Visibility.Visible;
                    break;
            }
        }
    }
}