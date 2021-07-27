using SmartHomeMVVM.Commands.BoilerCommands;
using SmartHomeMVVM.Models.Devices;
using SmartHomeMVVM.Stores;
using System.Windows.Input;

namespace SmartHomeMVVM.ViewModels
{
    class BoilerViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

        public Boiler _boiler;

        public ICommand TurnBoilerOnCommand { get; }
        public ICommand TurnOffBoilerCommand { get; }
        public ICommand IncreaseTemperatureByOneCommand { get; }
        public ICommand DecreaseTemperatureByOneCommand { get; }

        public Boiler Boiler
        {
            get
            {
                return _boiler;
            }
        }
        public BoilerViewModel(NavigationStore navigation, Boiler boiler)
        {
            _boiler = boiler;
            TurnBoilerOnCommand = new TurnOnBoilerCommand(boiler);
            TurnOffBoilerCommand = new TurnOffBoilerCommand(boiler);
            IncreaseTemperatureByOneCommand = new IncreaseTemperatureByOneCommand(boiler);
            DecreaseTemperatureByOneCommand = new DecreaseTemperatureByOneCommand(boiler);
            _navigationStore = navigation;
        }
    }
}
