using SmartHomeMVVM.Models.Devices;
using SmartHomeMVVM.Stores;
using SmartHomeMVVM.ViewModels;


namespace SmartHomeMVVM.Commands.NavigationCommands
{
    class NavigationCameraCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        private Camera _camera;

        public NavigationCameraCommand(NavigationStore navigationStore, Camera camera)
        {
            _navigationStore = navigationStore;
            _camera = camera;
        }
        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new CameraViewModel(_navigationStore, _camera);
        }
    }
}
