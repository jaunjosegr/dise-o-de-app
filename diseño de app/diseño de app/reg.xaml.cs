using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace diseño_de_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class reg : ContentPage
    {
        public reg()
        {
            InitializeComponent();
        }

        private void btngyc_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void btnregresar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void checkB_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }
    }
}