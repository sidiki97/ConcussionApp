using ConcussionApp.Models;
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
    public partial class Symptoms : ContentPage


    {

        private SymptomsInfo log = new SymptomsInfo() { Name = "Name" };

        private readonly IDictionary<double, string> severity = new Dictionary<double, string>()
        {
            {0, "None" },
            {1, "Mild" },
            {2, "Mild" },
            {3, "Moderate" },
            {4, "Moderate" },
            {5, "Severe" },
            {6,  "Severe" }
        };

        public Symptoms()
        {
            
            InitializeComponent();

            
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double newVal = ((Stepper)sender).Value;

            Grid parentElement = (Grid)(((Stepper)sender).Parent);

            Label childElementSeverity = (Label)(parentElement.Children[0]);
            childElementSeverity.Text = severity[newVal];

            Label childElementValue = (Label)(parentElement.Children[1]);
            childElementValue.Text = newVal.ToString();
            

        }


        private async void Save_Button_Clicked(object sender, EventArgs e)
        {
            var log = (SymptomsInfo)BindingContext;
            
            await App.Database.SaveSymptomsLog(log);
            await Navigation.PopAsync();
        }

        private async void Delete_Button_Clicked(object sender, EventArgs e)
        {
            var del = (SymptomsInfo)BindingContext;
            await App.Database.DeleteSymptomsEval(del);
            await Navigation.PopAsync();
        }
    }
}