using SmartHomeMVVM.Models.Devices;
using SmartHomeMVVM.Stores;
using SmartHomeMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeMVVM.Commands.NavigationCommands
{
    class NavigationTemperatureSensorCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        private TemperatureSensor _temperatureSensor;

        public NavigationTemperatureSensorCommand(NavigationStore navigationStore, TemperatureSensor temperatureSensor)
        {
            _navigationStore = navigationStore;
            _temperatureSensor = temperatureSensor;
        }
        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new TemperatureSensorViewModel(_navigationStore, _temperatureSensor);
        }
    }
}
