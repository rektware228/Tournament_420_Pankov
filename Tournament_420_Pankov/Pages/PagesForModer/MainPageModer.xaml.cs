﻿using System;
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

namespace Tournament_420_Pankov.Pages.PagesForModer
{
    /// <summary>
    /// Логика взаимодействия для MainPageModer.xaml
    /// </summary>
    public partial class MainPageModer : Page
    {
        public MainPageModer()
        {
            InitializeComponent();
        }

        private void BGoToCreateResultTour_Click(object sender, RoutedEventArgs e)
        {
           // NavigationService.Navigate(new GoToCreateResultTourPage());

        }

        private void BGoToLogin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());

        }
    }
}
