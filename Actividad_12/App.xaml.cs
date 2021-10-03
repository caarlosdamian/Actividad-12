using System;
using Xamarin.Forms;
using Actividad_12.Modelo;
using Actividad_12.Vistas;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;
using SQLite;

namespace Actividad_12
{
    public partial class App : Application
    {
        public static string RUTA_BD;
        public App(string ruta_db)
        {
            InitializeComponent();
            RUTA_BD = ruta_db;
            MainPage = new NavigationPage(new MainPage());
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
