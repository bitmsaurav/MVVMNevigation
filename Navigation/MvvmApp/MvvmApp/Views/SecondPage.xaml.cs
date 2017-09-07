using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;

namespace MvvmApp.Views
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
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

        protected override void OnAppearing()
        {
            ConNet.Text = CrossConnectivity.Current.IsConnected.ToString();
            CrossConnectivity.Current.ConnectivityChanged += UpdateNetworkInfo;
        }
        protected override void OnDisappearing()
        {
            CrossConnectivity.Current.ConnectivityChanged -= UpdateNetworkInfo;
        }
        private void UpdateNetworkInfo(object sender, ConnectivityChangedEventArgs e)
        {
            // ConNet.Text = CrossConnectivity.Current.IsConnected.ToString();
            ConNet.Text = CrossConnectivity.Current.IsReachable("www.consumerprotectionbc.ca", 5000).ToString();
            CrossConnectivity.Current.ConnectivityChanged += UpdateNetworkInfo;
        }
    }
}
