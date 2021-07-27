using SmartHomeMVVM.Models.Devices;

namespace SmartHomeMVVM.Commands.TemperatureSensorCommand
{
    class TurnTemperatureOnCommand : CommandBase
    {
        TemperatureSensor temperatureSensor;

        public TurnTemperatureOnCommand(TemperatureSensor temperatureSensor)
        {
            this.temperatureSensor = temperatureSensor;
        }

        public override void Execute(object parameter)
        {
            temperatureSensor.TurnOn();
        }
    }

}
