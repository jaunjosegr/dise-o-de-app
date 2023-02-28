using diseño_de_app.Model;
using Plugin.Media.Abstractions;
using Plugin.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.Permissions;
using System.Collections.ObjectModel;

namespace diseño_de_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Paginadecontenido : ContentPage
    {
        ObservableCollection<MediaModels> Photos = new ObservableCollection<MediaModels>();
        public Paginadecontenido()
        {
            InitializeComponent();
        }
       
        private async void btnfoto_Pressed(object sender, EventArgs e)
        {
            var isInitialize = await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported || !CrossMedia.IsSupported || !isInitialize)
            {
                await DisplayAlert("Error", "La camara no se encuentra disponible", "OK");
                return;
            }
            var newPhotoID = Guid.NewGuid();

            using (var photo = await CrossMedia.Current.TakePhotoAsync(new StoreVideoOptions()
            {
                Name = newPhotoID.ToString(),
                SaveToAlbum = true,
                DefaultCamera = CameraDevice.Rear,
                Directory = "Demo Camara",
                CustomPhotoSize = 50
            }))
            {
                if (string.IsNullOrWhiteSpace(photo?.Path))
                {
                    return;
                }
                var newPhotoMedia = new MediaModels()
                {
                    MediaID = newPhotoID,
                    Path = photo.Path,
                    LocalDataTime = DateTime.Now

                };

                Photos.Add(newPhotoMedia);

                photo.Dispose();
            }
            listFoto.ItemsSource = Photos;
        }
    }
}