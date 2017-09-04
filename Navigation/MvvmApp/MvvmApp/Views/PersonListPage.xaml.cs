using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmApp.ViewModels;

using Xamarin.Forms;

namespace MvvmApp.Views
{
    public partial class PersonListPage : ContentPage
    {
        public PersonListPage()
        {
            InitializeComponent();
            PersonViewModel personViewModel = new PersonViewModel();
            ListOfPersons.ItemsSource = personViewModel.PersonList;
        }


        private async void SayHelloButton_OnClicked(object sender, EventArgs e)
        {
            var name = NameEntry1.Text;
            await DisplayAlert("Greeting", $"Hello {name}!", "Howdy");
        }


    }
}
