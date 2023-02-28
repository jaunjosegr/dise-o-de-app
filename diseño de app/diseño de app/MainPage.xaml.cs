using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace diseño_de_app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var list = new List<String>
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8"
            };
            TheCarousel.ItemsSource = list;
        }
    }
}
