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

namespace PC_SHOP.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (App.Conetext.Пользователи.Count(x => x.Логин == TBlogin.Text) > 0)
            {
                MessageBox.Show("Пользователь с именем " + TBlogin.Text + " уже существует", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else
            {
                try
                {
                    DataBase.Пользователи user = new DataBase.Пользователи()
                    {
                        Логин = TBlogin.Text,
                        Пароль = RetPBox.Password,
                        ID_Роли = 2
                    };

                    App.Conetext.Пользователи.Add(user);
                    App.Conetext.SaveChanges();

                    MessageBox.Show("Пользователь успешно создан!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.GoBack();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Что-то пошло не так" + "\n" + ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void RetPBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if(RetPBox.Password == PBox.Password)
            {
                BtnCreate.Foreground = new SolidColorBrush(Colors.White);
                BtnCreate.IsEnabled = true;
                StatusText.Text = " ";
            }
            else
            {
                BtnCreate.Foreground = new SolidColorBrush(Colors.Black);
                BtnCreate.IsEnabled = false;
                StatusText.Text = "Пароли не совпадают!";
                StatusText.Foreground = new SolidColorBrush(Colors.Red);
                RetPBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }
        public static bool PassCheck(string pwd)
        {
            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a - z])(?=.*?[0-9])(?=.*?[#?!@$^&*_-]).{8,}$");
            Match m = regex.Match(pwd);

            return m.Success;
        }
    }
}
