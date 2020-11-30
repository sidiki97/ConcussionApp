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

            

            NavigateCommand = new Command<Type>(
            async (pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });

            BindingContext = this;
        }

        public ICommand NavigateCommand { private set; get; }
    }
}
