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

namespace PC_SHOP.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void BtnEntry_Click(object sender, RoutedEventArgs e)
        {
            var currentUser = App.Conetext.Пользователи.FirstOrDefault(p => p.Логин == TBlogin.Text && p.Пароль == PBox.Password);

            if (currentUser != null)
            {
                App.users = currentUser;
                // обработчик раздельного входа в приложение, если роль пользователя == 2, то перехол на страницу товаров
                if (App.users.ID_Роли == 2)
                {
                    NavigationService.Navigate(new Pages.GoodsPage());
                }
                else
                {
                    MessageBox.Show("Успешный вход", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Неверно введенные данные" + " или пользователь не зарегистрирован", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                TBlogin.Focus();
            }
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.RegPage());
        }
    }    
}