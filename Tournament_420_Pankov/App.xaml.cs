using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Tournament_420_Pankov.Models;

namespace Tournament_420_Pankov
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static TournamentDB_420_PankovEntities DB = new TournamentDB_420_PankovEntities();
    }
}
