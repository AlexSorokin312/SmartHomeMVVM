using SmartHomeMVVM.Models.Devices;
using SmartHomeMVVM.Commands;
using SmartHomeMVVM.Stores;
using System.Windows.Input;
using SmartHomeMVVM.Commands.NavigationCommands;
using SmartHomeMVVM.Models.DeviceFactory;

namespace SmartHomeMVVM.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        DevicesFactory factory;
        Device camera;
        Device boiler;
        Device temperatureSensor;

        private readonly NavigationStore _navigationStore;
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
        public ICommand NavigateBoilerCommand { get; }
        public ICommand NavigationCameraCommand { get; }
        public ICommand NavigationTemperatureSensorCommand { get; }

        public MainViewModel(NavigationStore navigationStore)
        {
            factory = new DevicesFactory();

            camera = factory.createDevice(DeviceType.Camera, "Уличная камера");
            boiler = factory.createDevice(DeviceType.Boiler, "Котёл №1");
            temperatureSensor = factory.createDevice(DeviceType.TemperatureSensor, "Датчик температуры");
            _navigationStore = navigationStore;

            _navigationStore.CurrentViewModelChanged += onCurrentViewModelChanged;

            NavigationCameraCommand = new NavigationCameraCommand(_navigationStore, (Camera)camera);
            NavigateBoilerCommand = new NavigateBoilerCommand(_navigationStore, (Boiler)boiler);
            NavigationTemperatureSensorCommand = new NavigationTemperatureSensorCommand(_navigationStore,
                (TemperatureSensor)temperatureSensor);
        }

        public void onCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

    }
}
