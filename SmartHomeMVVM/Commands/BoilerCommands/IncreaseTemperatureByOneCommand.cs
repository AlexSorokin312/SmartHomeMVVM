using SmartHomeMVVM.Models.Devices;

namespace SmartHomeMVVM.Commands.BoilerCommands
{
    class IncreaseTemperatureByOneCommand : CommandBase
    {
        Boiler boiler;
        public IncreaseTemperatureByOneCommand(Boiler boiler)
        {
            this.boiler = boiler;
        }

        public override void Execute(object parameter)
        {
            boiler.IncreaseTemperatureByOneDegree();
        }
    }
}
