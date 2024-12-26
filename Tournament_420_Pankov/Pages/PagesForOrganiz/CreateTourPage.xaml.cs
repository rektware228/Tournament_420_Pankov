using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Tournament_420_Pankov.Models;  // Примерное пространство имён, где лежит модель Tournament

namespace Tournament_420_Pankov.Pages
{
    public partial class AddTournamentPage : Page
    {
        //private Tournaments _contextTournament;

        //public AddTournamentPage(Tournaments tournament)
        //{
        //    InitializeComponent();

        //    // Сохраняем ссылку на переданный объект (новый или существующий)
        //    _contextTournament = tournament ?? new Tournaments();
        //    DataContext = _contextTournament;
        //}

        //private void Page_Loaded(object sender, RoutedEventArgs e)
        //{
        //    // Заполняем ComboBox Category (CBCategory) из БД:
        //    CBCategory.ItemsSource = App.DB.Category.ToList();

        //    // Заполняем ComboBox Organizer (CBOrganizer) из БД:
        //    CBOrganizer.ItemsSource = App.DB.Organizers.ToList();


        //}

        //// Обработчик сохранения
        //private void BSave_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        // Если у объекта нет ID (значит новый), то добавляем
        //        if (_contextTournament.TournamentID == 0)
        //        {
        //            App.DB.Tournaments.Add(_contextTournament);
        //        }

        //        // Сохраняем изменения
        //        App.DB.SaveChanges();
        //        MessageBox.Show("Турнир успешно сохранён!", "Информация",
        //                        MessageBoxButton.OK, MessageBoxImage.Information);

        //        // Возврат на предыдущую страницу (или куда нужно)
        //        NavigationService.GoBack();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Ошибка при сохранении: {ex.Message}",
        //                        "Ошибка",
        //                        MessageBoxButton.OK,
        //                        MessageBoxImage.Error);
        //    }
        //}

        //private void BBack_Click(object sender, RoutedEventArgs e)
        //{
        //    NavigationService.GoBack();
        //}

        //// Универсальный метод для "только цифры" в TextBox
        //private void DigitsOnly_PreviewTextInput(object sender, TextCompositionEventArgs e)
        //{
        //    // Разрешаем только цифры
        //    if (!Regex.IsMatch(e.Text, @"^\d+$"))
        //    {
        //        e.Handled = true; // блокируем ввод
        //    }
        //}
    }
}
