using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tournament_420_Pankov.Models;

namespace Tournament_420_Pankov.Pages.PagesForOrganiz
{
    /// <summary>
    /// Логика взаимодействия для MainPageOrganizers.xaml
    /// </summary>
    public partial class MainPageOrganizers : Page
    {
        public MainPageOrganizers()
        {
            InitializeComponent();
        }

        private void BGoToLogin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
        }

        private void BGoToCreateTour_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateTourPage());
        }

        private void BGoToparticipantManagement_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ParticipantManagementPage());
        }

        private void BenteringResults_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BenteringResultsPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
         
        }
    }
}
