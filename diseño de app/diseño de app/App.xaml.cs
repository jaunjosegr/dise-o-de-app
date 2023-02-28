using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace diseño_de_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Paginadecontenido());
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
