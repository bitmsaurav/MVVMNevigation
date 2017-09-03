using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MvvmApp.Views
{
    public partial class PersonListPage : ContentPage
    {
        public PersonListPage()
        {
            InitializeComponent();
        }


        private async void SayHelloButton_OnClicked(object sender, EventArgs e)
        {
            var name = NameEntry1.Text;
            await DisplayAlert("Greeting", $"Hello {name}!", "Howdy");
        }


        private async void DoThisButton_OnClicked(object sender, EventArgs e)
        {
            var text = DoThis.Text;
            await DisplayAlert("Greeting", $"Hello {text}!", "Howdy");
        }


    }
}
