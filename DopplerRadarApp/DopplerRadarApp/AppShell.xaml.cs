using DopplerRadarApp.ViewModels;
using DopplerRadarApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DopplerRadarApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        }

    }
}
