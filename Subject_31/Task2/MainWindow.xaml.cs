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
        }

        private void ShowAllTours_Click(object sender, RoutedEventArgs e)
        {
            DataGridResults.ItemsSource = tourManager.GetAllTours();
        }

        private void DeleteTour_Click(object sender, RoutedEventArgs e)
        {
            int tourIdToDelete = 1;
            tourManager.DeleteTour(tourIdToDelete);
            ShowAllTours_Click(sender, e);
        }

        private void AddTourist_Click(object sender, RoutedEventArgs e)
        {
            int tourId = 1; 
            string touristName = "John Doe"; 
            tourManager.AddTourist(tourId, touristName);
            ShowAllTours_Click(sender, e);
        }

        private void UpdateTourist_Click(object sender, RoutedEventArgs e)
        {
            int touristIdToUpdate = 1;
            string updatedName = "Updated Name";
            tourManager.UpdateTourist(touristIdToUpdate, updatedName);
            ShowAllTours_Click(sender, e);
        }
    }
}