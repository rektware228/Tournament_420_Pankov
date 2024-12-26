using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class BenteringResultsPage : Page
    {

        public BenteringResultsPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            var matchList = App.DB.Matches
                .Where(m => m.Score == null || m.Score == "")
                .ToList();

            var matchListView = matchList.Select(m => new
            {
                OriginalMatch = m, MatchInfo = $"Match #{m.MatchID} | TurID={m.TournamentID} | {m.MatchStartTime:g}"
            })
            .ToList();

            CBMatches.ItemsSource = matchListView;
            

            CBMatches.SelectedIndex = 0; // берем первыый 
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            // 1. Получаем выбранный элемент
            var selItem = CBMatches.SelectedItem;
            if (selItem == null)
            {
                MessageBox.Show("Выберите матч для сохранения результата.",
                                "Внимание",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                return;
            }

           
            var matchObj = selItem.GetType().GetProperty("OriginalMatch").GetValue(selItem) as Matches;

            if (matchObj == null)
            {
                MessageBox.Show("Не удалось получить объект матча.",
                                "Ошибка",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
                return;
            }

            
            matchObj.Score = TBScore.Text; // "2:1", "16:9" и т.п.
            int duration = 0;
            if (!string.IsNullOrWhiteSpace(TBDuration.Text))
                int.TryParse(TBDuration.Text, out duration);
            matchObj.DurationMinutes = duration;

            try
            {
                App.DB.SaveChanges();
                MessageBox.Show("Результат матча успешно сохранён!",
                                "Информация",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}",
                                "Ошибка",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        //ообработчик 
        private void DigitsOnly_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Разрешаем только цифры
            if (!Regex.IsMatch(e.Text, @"^\d+$"))
            {
                e.Handled = true; 
            }
        }
    }
}
