using SmartHomeMVVM.Models.Devices;


namespace SmartHomeMVVM.Commands.BoilerCommands
{
    class TurnOffBoilerCommand : CommandBase
    {
        Boiler boiler;
        public TurnOffBoilerCommand(Boiler boiler)
        {
            this.boiler = boiler;
        }

        public override void Execute(object parameter)
        {
            boiler.TurnOff();
        }
    }
}
