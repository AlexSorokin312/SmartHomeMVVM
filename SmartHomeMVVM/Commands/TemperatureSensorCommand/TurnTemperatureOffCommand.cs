
using SmartHomeMVVM.Models.Devices;

namespace SmartHomeMVVM.Commands.TemperatureSensorCommand
{
    class TurnTemperatureOffCommand : CommandBase
    {
        TemperatureSensor temperatureSensor;

        public TurnTemperatureOffCommand(TemperatureSensor temperatureSensor)
        {
            this.temperatureSensor = temperatureSensor;
        }

        public override void Execute(object parameter)
        {
            temperatureSensor.TurnOff();
        }
    }
}
