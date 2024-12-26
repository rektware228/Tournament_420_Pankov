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


namespace Tournament_420_Pankov.Pages
{
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void BReg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TBName.Text) ||
                    string.IsNullOrWhiteSpace(TBContact.Text) ||
                    string.IsNullOrWhiteSpace(TBLogin.Text) ||
                    string.IsNullOrWhiteSpace(TBPassword.Password) ||
                    string.IsNullOrWhiteSpace(TBAccessLevelID.Text))
                {
                    MessageBox.Show("Заполните все поля!",
                                    "Внимание",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Warning);
                    return;
                }
                //
                if (!int.TryParse(TBAccessLevelID.Text.Trim(), out int levelID))
                {
                    MessageBox.Show("Уровень доступа должен быть числом 1 или 2.",
                                    "Ошибка",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                    return;
                }
                if (levelID != 1 && levelID != 2)
                {
                    MessageBox.Show("Уровень доступа может быть только 1 (admin) или 2 (moderator).",
                                    "Ошибка",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                    return;
                }

                var existingUser = App.DB.Organizers.FirstOrDefault(o => o.Login == TBLogin.Text.Trim());
                if (existingUser != null)
                {
                    MessageBox.Show("Такой логин уже существует!",
                                    "Ошибка",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                    return;
                }

                
                var newOrganizer = new Organizers
                {
                    OrganizerName = TBName.Text.Trim(),
                    ContactInfo = TBContact.Text.Trim(),
                    Login = TBLogin.Text.Trim(),
                    Password = TBPassword.Password.Trim(),
                    AccessLevelID = levelID
                };

          
                App.DB.Organizers.Add(newOrganizer);
                App.DB.SaveChanges();

                MessageBox.Show("Регистрация успешно завершена!",
                                "Информация",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
                if (NavigationService.CanGoBack)
                    NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации: {ex.Message}",
                                "Ошибка",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();
        }
    }
}
