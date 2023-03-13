using DopplerRadarApp.Models;
using DopplerRadarApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DopplerRadarApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanPage : ContentPage
    {
        private readonly DopplerRadarBLE _dopplerRadarBLE;
        public ScanPage(DopplerRadarBLE dopplerRadarBLE)
        {
            InitializeComponent();
            _dopplerRadarBLE = dopplerRadarBLE;
            BindingContext = new ScanViewModel(_dopplerRadarBLE);
        }
    }
}