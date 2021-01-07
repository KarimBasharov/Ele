using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ele
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void element_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Menu());
        }

        /*private async void MainPage_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Menu());
        }*/

        /*private async void MainPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Datepicker());
        }*/
    }
}
