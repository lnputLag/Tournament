﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Инициализация соединения с БД
            TrackerLibrary.GlobalConfig.InitializeConnections(true, true);
            Application.Run(new CreatePrizeForm());


            //Application.Run(new TournamentDashboardForm());
        }
    }
}
