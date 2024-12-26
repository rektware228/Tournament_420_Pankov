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
using Tournament_420_Pankov.Pages.PagesForModer;
using Tournament_420_Pankov.Pages.PagesForOrganiz;
using Tournament_420_Pankov.Pages.PagesForUsers;

namespace Tournament_420_Pankov.Pages
{
    public partial class LoginPage : Page
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public LoginPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            // 1. Если логин и пароль НЕ пустые:
            if (!string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Password))
            {
                // Ищем пользователя в БД
                var user = App.DB.Organizers.FirstOrDefault(x => x.Login == Login && x.Password == Password);

                // 2. Если пользователь найден
                if (user != null)
                {
                    // Проверяем AccessLevelID
                    if (user.AccessLevelID == 1)
                    {
                        // Если роль = 1 (Admin) -> переходим на MainPageOrganizers
                        NavigationService.Navigate(new MainPageOrganizers());
                    }
                    else if (user.AccessLevelID == 2)
                    {
                        // Если роль = 2 (Moderator) -> переходим на MainPageModer
                        NavigationService.Navigate(new MainPageModer());
                    }
                    else
                    {
                        // Иначе считаем это ролью пользователя (User) -> MainPageUsers
                        NavigationService.Navigate(new MainPageUsers());
                    }
                }
                else
                {
                    // Пользователь не найден
                    MessageBox.Show("Неверный логин или пароль.",
                                    "Ошибка входа",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Warning);
                }
            }
            else
            {
                // 3. Если логин и/или пароль пустые -> сразу на MainPageUsers
                NavigationService.Navigate(new MainPageUsers());
            }
        }

        private void BReg_Click(object sender, RoutedEventArgs e)
        {
            // Код для обработки кнопки "Регистрация"
            // Например, переход на страницу регистрации
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
