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

namespace Tournament_420_Pankov.Pages.PagesForUsers
{
    /// <summary>
    /// Логика взаимодействия для ViewAllTournamentsPage.xaml
    /// </summary>
    public partial class ViewAllTournamentsPage : Page

    {
        private List<Tournaments> _allTournaments;

        public ViewAllTournamentsPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // Загружаем все турниры из БД
            _allTournaments = App.DB.Tournaments.ToList();
            // Привязываем к DataGrid
            DG_Tournaments.ItemsSource = _allTournaments;
        }

        private void CBFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (CBFilter.SelectedItem is ComboBoxItem selectedItem)
            //{
            //    string filterTag = selectedItem.Tag?.ToString();
            //    DG_Tournaments.ItemsSource = FilterTournaments(filterTag);

            //}
        }

        // Пример фильтра по дате начала/окончания
        private List<Tournaments> FilterTournaments(string filterTag)
        {
            if (filterTag == "All")
            {
                return _allTournaments;
            }
            else if (filterTag == "Upcoming")
            {
                // Предстоящие
                return _allTournaments
                    .Where(t => t.StartDate > DateTime.Now)
                    .ToList();
            }
            else if (filterTag == "Ongoing")
            {
                // Текущие
                return _allTournaments
                    .Where(t => t.StartDate <= DateTime.Now && (t.EndDate == null || t.EndDate > DateTime.Now))
                    .ToList();
            }
            else if (filterTag == "Finished")
            {
                // Завершённые
                return _allTournaments
                    .Where(t => t.EndDate != null && t.EndDate < DateTime.Now)
                    .ToList();
            }
            return _allTournaments;
        }


    }
}
