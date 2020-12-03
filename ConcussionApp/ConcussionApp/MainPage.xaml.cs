using ConcussionApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ConcussionApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            

            

            BindingContext = this;
        }

        

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Symptoms());
        }
    }
}
