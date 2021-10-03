using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Actividad_12.Modelo;
using Actividad_12.Vistas;
using Xamarin.Forms.Internals;
using SQLite;

namespace Actividad_12
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            lstPersonas.ItemsSource = null;
            using (var conn = new SQLiteConnection(App.RUTA_BD))
            {
                conn.CreateTable<Persona>();
                lstPersonas.ItemsSource = conn.Table<Persona>().ToList();
            }
        }
    

        private void lblNuevo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NuevoPage() {BindingContext = new Persona() });
        }

        private void lstPersonas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Persona persona = (Persona)e.SelectedItem;
            Navigation.PushAsync(new NuevoPage() { BindingContext = persona });
        }
    }
}
