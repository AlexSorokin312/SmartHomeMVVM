
using SmartHomeMVVM.Models.Devices;

namespace SmartHomeMVVM.Commands.BoilerCommands
{
    class TurnOnBoilerCommand : CommandBase
    {
        Boiler boiler;
        public TurnOnBoilerCommand(Boiler boiler)
        {
            this.boiler = boiler;
        }

        public override void Execute(object parameter)
        {
            boiler.TurnOn();
        }
    }
}
