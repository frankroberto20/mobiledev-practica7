using System;
using System.Collections.Generic;
using System.Text;
using DependencyServicePractica.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace DependencyServicePractica.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Orientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation();
        }

        public DeviceOrientation Orientation { get; set; }
    }
}
