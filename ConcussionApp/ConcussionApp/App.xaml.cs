using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConcussionApp
{
    public partial class App : Application
    {
        public App()
        {
           
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#bb0000")
            };
            
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
