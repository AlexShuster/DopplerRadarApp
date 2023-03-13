using DopplerRadarApp.Commands;
using DopplerRadarApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DopplerRadarApp.ViewModels
{
    internal class ScanViewModel : BaseViewModel
    {
        public ICommand ScanCommand { get; }

        public ScanViewModel(DopplerRadarBLE dopplerRadarBLE)
        {
            ScanCommand = new ScanCommand(dopplerRadarBLE);
        }
        public ScanViewModel()
        {

        }
    }
}
