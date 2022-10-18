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
using PC_SHOP.Pages;

namespace PC_SHOP.Pages
{
    /// <summary>
    /// Логика взаимодействия для GoodsPage.xaml
    /// </summary>
    public partial class GoodsPage : Page
    {
        public GoodsPage()
        {
            InitializeComponent();
            ComboSortBy.SelectedIndex = 0;
            Update();
        }

        private void ComboSortBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void Category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Товар должен быть добавлен в корзину", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Update()
        {
            var goods = App.Conetext.Товары.ToList();

            if (ComboSortBy.SelectedIndex == 0)
            {
                goods = goods.OrderBy(p => p.Цена).ToList();
            }
            else
            {
                goods = goods.OrderByDescending(p => p.Цена).ToList();
            }
             
            if(Category.SelectedIndex == 0)
            {
                goods = goods.Where(p => p.Код_категории == 1).ToList();    
            }
            if (Category.SelectedIndex == 1)
            {
                goods = goods.Where(p => p.Код_категории == 2).ToList();
            }
            if (Category.SelectedIndex == 2)
            {
                goods = goods.Where(p => p.Код_категории == 3).ToList();
            }
            if (Category.SelectedIndex == 3)
            {
                goods = goods.Where(p => p.Код_категории == 4).ToList();
            }
            if (Category.SelectedIndex == 4)
            {
                goods = goods.Where(p => p.Код_категории == 5).ToList();
            }
            if (Category.SelectedIndex == 5)
            {
                goods = goods.Where(p => p.Код_категории == 6).ToList();
            }
            if (Category.SelectedIndex == 6)
            {
                goods = goods.Where(p => p.Код_категории == 7).ToList();
            }
            if (Category.SelectedIndex == 7)
            {
                goods = goods.Where(p => p.Код_категории == 8).ToList();
            }

            goods = goods.Where(p => p.Наименование.ToLower().Contains(SearchBox.Text.ToLower())).ToList();

            LVGoods.ItemsSource = goods;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
