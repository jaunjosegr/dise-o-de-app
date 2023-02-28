using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace diseño_de_app.Model
{
    public class MediaModels
    {
        public Guid MediaID { get; set; }
        public string Path { get; set; }
        public DateTime LocalDataTime { get; set; }

        private FileImageSource source = null;
        public FileImageSource Source => source ?? (source = new FileImageSource() { File = Path });

    }
}