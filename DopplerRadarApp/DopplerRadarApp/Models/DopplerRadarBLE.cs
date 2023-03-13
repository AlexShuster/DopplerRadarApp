using Android.Bluetooth;
using BluetoothLE.Core;
using BluetoothLE.Core.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DopplerRadarApp.Models
{
    public class DopplerRadarBLE
    {
        public IAdapter BluetoothAdapter;

        // List of Discovered Devices
        ObservableCollection<IDevice> DeviceList;

        private void DeviceDiscovered(object sender, DeviceDiscoveredEventArgs e)
        {
            if (DeviceList.All(x => x.Id != e.Device.Id))
            {
                DeviceList.Add(e.Device);
            }
        }

        public DopplerRadarBLE()
        {

        }

        //// BluetoothAdapter.StartScanningForDevices();   Call when san button is pressed


        //private void DeviceDiscovered(object sender, DeviceDiscoveredEventArgs e)
        //{
        //    if (DeviceList.All(x => x.Id != e.Device.Id))
        //    {
        //        DeviceList.Add(e.Device);
        //    }
        //}
    }
}
