using SmartHomeMVVM.Models.Devices;

namespace SmartHomeMVVM.Commands.BoilerCommands
{
    class DecreaseTemperatureByOneCommand : CommandBase
    {
        Boiler boiler;
        public DecreaseTemperatureByOneCommand(Boiler boiler)
        {
            this.boiler = boiler;
        }

        public override void Execute(object parameter)
        {
            boiler.DecreaseTemperatureByOneDegree();
        }
    }
}
