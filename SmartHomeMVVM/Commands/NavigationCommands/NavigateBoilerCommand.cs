using SmartHomeMVVM.Models.Devices;
using SmartHomeMVVM.Stores;
using SmartHomeMVVM.ViewModels;

namespace SmartHomeMVVM.Commands
{
    class NavigateBoilerCommand : CommandBase
    {

        private readonly NavigationStore _navigationStore;
        private Boiler _boiler;
        public NavigateBoilerCommand(NavigationStore navigationStore, Boiler boiler)
        {
            _navigationStore = navigationStore;
            _boiler = boiler;
        }
            public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new BoilerViewModel(_navigationStore, _boiler);
        }
    }
}
