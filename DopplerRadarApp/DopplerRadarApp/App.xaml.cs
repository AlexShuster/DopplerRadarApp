using DopplerRadarApp.Models;
using DopplerRadarApp.Services;
using DopplerRadarApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DopplerRadarApp
{
    public partial class App : Application
    {
        private readonly DopplerRadarBLE _bluetoothHandler;

        public App()
        {
            InitializeComponent();

            _bluetoothHandler = new DopplerRadarBLE();

            MainPage = new NavigationPage(new ScanPage(_bluetoothHandler))
            {
                BackgroundColor = Color.CadetBlue,
                BarTextColor = Color.White
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
