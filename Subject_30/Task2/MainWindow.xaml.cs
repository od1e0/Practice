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
using Task2.Services;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly TourManager tourManager;

        public MainWindow()
        {
            InitializeComponent();
            tourManager = new TourManager("Data Source=DESKTOP-N2LUKQT;Initial Catalog=DBTur_firm;Integrated Security=True;TrustServerCertificate=True");
            RefreshToursDataGrid();
        }

        private void AddTour_Click(object sender, RoutedEventArgs e)
        {
            string tourName = TourNameTextBox.Text;
            tourManager.AddTour(tourName);
            RefreshToursDataGrid();
        }

        private void AddTourist_Click(object sender, RoutedEventArgs e)
        {
            string touristName = TouristNameTextBox.Text;
            tourManager.AddTourist(touristName); 
            RefreshToursDataGrid();
        }
        private void RefreshToursDataGrid()
        {
            ToursDataGrid.ItemsSource = tourManager.GetTours();
        }
    }
}