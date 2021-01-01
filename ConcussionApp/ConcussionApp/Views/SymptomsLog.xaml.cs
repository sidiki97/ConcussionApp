using ConcussionApp.Models;
using System;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConcussionApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SymptomsLog : ContentPage
    {

        private int numTaps = 1;

        public SymptomsLog()
        {

            NavigationPage.SetHasBackButton(this, false);

            

            InitializeComponent();

            
        }
        
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetSymptomsInfos();
        }



        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Symptoms
            {
                BindingContext = new SymptomsInfo()
            });

        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new Symptoms
                {
                    BindingContext = e.SelectedItem as SymptomsInfo
                });
            }
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            if (numTaps == 1)
            {
                listView.ItemsSource = await App.Database.OrderByScoreAsc();
                numTaps = 2;
            }
            else
            {
                listView.ItemsSource = await App.Database.OrderByScoreDesc();
                numTaps = 1;
            }
            
        }

        private async void Rearrange_ImageButton_Clicked(object sender, EventArgs e)
        {
            listView.ItemsSource = await App.Database.GetSymptomsInfos();
        }

        private async void Trash_ImageButton_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Delete All Patients", "Are you sure you want to DELETE ALL patients?", "Yes", "No");
            if (answer)
            {
                await App.Database.DeleteAllPatients();
                listView.ItemsSource = null;
            }
            
            
        }
    }
}