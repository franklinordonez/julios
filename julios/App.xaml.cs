using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace julios
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Registro()); // Habilitar la Navegación
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
