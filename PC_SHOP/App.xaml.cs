using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PC_SHOP
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static DataBase.PC_SHOPE_DB Conetext { get; set; } = new DataBase.PC_SHOPE_DB();
        public static DataBase.Пользователи users = null;
    }
}
