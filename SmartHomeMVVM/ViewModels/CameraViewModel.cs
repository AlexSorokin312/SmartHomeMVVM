using SmartHomeMVVM.Commands;
using SmartHomeMVVM.Commands.CameraCommands;
using SmartHomeMVVM.Models.Devices;
using SmartHomeMVVM.Stores;
using System.ComponentModel;
using System.Windows.Input;

namespace SmartHomeMVVM.ViewModels
{
    class CameraViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public ICommand TurnCameraOnCommand { get; }
        public ICommand TurnCameraOffCommand { get; }
        public ICommand TurnOnMovementSensorCommand { get; }
        public ICommand TurnOffMovementSensorCommand { get; }

        public Camera _camera;
        public Camera Camera
        {
            get
            {
                return _camera;
            }
        }

        private readonly NavigationStore _navigationStore;
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

        public CameraViewModel(NavigationStore navigation, Camera camera)
        {
            _camera = camera;
            _navigationStore = navigation;
            TurnCameraOnCommand = new TurnCameraOnCommand(camera);
            TurnCameraOffCommand = new TurnCameraOffCommand(camera);
            TurnOnMovementSensorCommand = new TurnOnMovementSensorCommand(camera);
            TurnOffMovementSensorCommand = new TurnOffMovementSensorCommand(camera);
            OnPropertyChanged("Camera");

        }
    }
}
