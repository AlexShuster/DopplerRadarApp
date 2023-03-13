using DopplerRadarApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DopplerRadarApp.Commands
{
    public class ScanCommand : CommandBase
    {
        private readonly DopplerRadarBLE _dopplerRadarBLE;
        public ScanCommand(DopplerRadarBLE dopplerRadarBLE)
        {
            _dopplerRadarBLE = dopplerRadarBLE;
        }
        public override void Execute(object parameter)
        {
            // Scan for Bluetooth Devices
            _dopplerRadarBLE.BluetoothAdapter.StartScanningForDevices();
            // _dopplerRadarBLE
        }
    }
}
