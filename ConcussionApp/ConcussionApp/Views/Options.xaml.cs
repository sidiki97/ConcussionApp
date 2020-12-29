using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConcussionApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Options : ContentPage
    {
        public Options()
        {
            NavigationPage.SetHasBackButton(this, false);
            
            InitializeComponent();
        }

        private async void Add_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Symptoms());
        }

        private async void View_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SymptomsLog());
        }
    }
}