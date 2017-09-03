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
            GenderPicker.Items.Add("Male");
            GenderPicker.Items.Add("Female");
        }


        private async void SayHelloButton_OnClicked(object sender, EventArgs e)
        {
            var name = NameEntry.Text;
            await DisplayAlert("Greeting", $"Hello {name}!", "Howdy");
        }


        private async void DoThisButton_OnClicked(object sender, EventArgs e)
        {
            var text = DoThis.Text;
            await DisplayAlert("Greeting", $"Hello {text}!", "Howdy");
        }

        private void GenderPicker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var gender = GenderPicker.Items[GenderPicker.SelectedIndex];
        }
    }
}
