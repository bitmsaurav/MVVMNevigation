using MvvmApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;


namespace MvvmApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

              MainPage = new NavigationPage(new FirstPage());
          //  MainPage = new NavigationPage(new SecondPage());
          //  MainPage = new NavigationPage(new PersonListPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            CrossConnectivity.Current.ConnectivityChanged += HandleConnectivityChanged;
            // To Use:  CrossConnectivity.Current.IsConnected  OR
            //CrossConnectivity.Current.IsReachable(" www.consumerprotectionbc.ca", 5000);

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

 
        void HandleConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            var connections = CrossConnectivity.Current.ConnectionTypes;

            foreach (var connection in connections)
            {
                switch (connection)
                {
                    case ConnectionType.Cellular:
                        {
                            System.Diagnostics.Debug.WriteLine("Cellular Connection Available");
                            break;
                        }

                    case ConnectionType.WiFi:
                        {
                            System.Diagnostics.Debug.WriteLine("WiFi Connection Available");
                            break;
                        }
                    case ConnectionType.Desktop:
                        {
                            System.Diagnostics.Debug.WriteLine("Desktop Connection Available");
                            break;
                        }
                }
            }

        }
    }
}
