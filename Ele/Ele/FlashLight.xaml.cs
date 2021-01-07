using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ele
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlashLight : ContentPage
    {
        public FlashLight()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Flashlight.TurnOnAsync();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Flashlight.TurnOffAsync();
        }
    }
}