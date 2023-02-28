using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace diseño_de_app.Animaciones
{
    public class POP : TriggerAction<Button>
    {
        protected override async void Invoke(Button sender)
        {
            uint timepo = 50;
            await sender.TranslateTo(-15,0, timepo );
            await sender.TranslateTo(15, 0, timepo);
            await sender.TranslateTo(-10, 0, timepo);
            await sender.TranslateTo(10, 0, timepo);
            await sender.TranslateTo(-5, 0, timepo);
            await sender.TranslateTo(5, 0, timepo);
            sender.TranslationX = 0;
        }
    }
}
