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
using Tournament_420_Pankov.Pages.PagesForOrganiz;

namespace Tournament_420_Pankov.Pages.PagesForUsers
{
    /// <summary>
    /// Логика взаимодействия для MainPageUsers.xaml
    /// </summary>
    public partial class MainPageUsers : Page
    {
        public MainPageUsers()
        {
            InitializeComponent();
        }

        private void BViewAllTournaments_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ViewAllTournamentsPage());
        }

        private void BGoToRates_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RatesPage());
        }

        private void BGoToLogin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());

        }
    }
}
