using SmartHomeMVVM.Commands.TemperatureSensorCommand;
using SmartHomeMVVM.Models.Devices;
using SmartHomeMVVM.Stores;
using System.Windows.Input;

namespace SmartHomeMVVM.ViewModels
{
    class TemperatureSensorViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

        public TemperatureSensor _temperatureSensor;
        public ICommand TurnTemperatureSensorOnCommand { get; }
        public ICommand TurnTemperatureSensorOffCommand { get; }
        public TemperatureSensor TemperatureSensor
        {
            get
            {
                return _temperatureSensor;
            }
        }
        public TemperatureSensorViewModel(NavigationStore navigation, TemperatureSensor temperateSensor)
        {
            _temperatureSensor = temperateSensor;
            _navigationStore = navigation;
            TurnTemperatureSensorOnCommand = new TurnTemperatureOnCommand(_temperatureSensor);
            TurnTemperatureSensorOffCommand = new TurnTemperatureOffCommand(_temperatureSensor);
        }
    }
}
