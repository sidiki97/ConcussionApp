using ConcussionApp.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConcussionApp
{
    public partial class App : Application
    { 

        static SymptomsInfoDatabase database;

        public App()
        {
           
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#bb0000")
            };
            
        }

        public static SymptomsInfoDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new SymptomsInfoDatabase();
                }
                return database;
            }
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
