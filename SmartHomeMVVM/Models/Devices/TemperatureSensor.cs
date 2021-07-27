using SmartHomeMVVM.Models.Devices.ITurnOnDevice;
using SmartHomeMVVM.Models.Devices.ITurnOffDevice;
using System.ComponentModel;

namespace SmartHomeMVVM.Models.Devices
{
    class TemperatureSensor : Device, INotifyPropertyChanged
    {
        private const string TEMPERATURE_SENSOR_ON = "Датчик температуры включен";
        private const string TEMPERATURE_SENSOR_OFF = "Датчик температуры выключен";
        ITurnOff turnOffTemperatureSensor;
        ITurnOn turnOnTemperatureSensor;
        public string temperatureSensorState { get; set; }
        private bool isOn { get; set; }
        public TemperatureSensor(string name) : base(name)
        {
            isOn = false;
            temperatureSensorState = TEMPERATURE_SENSOR_OFF;
            turnOnTemperatureSensor = new TurnOn();
            turnOffTemperatureSensor = new TurnOff();
        }
        public void TurnOn()
        {
            isOn = turnOnTemperatureSensor.TurnOnDevice();
            temperatureSensorState = TEMPERATURE_SENSOR_ON;
            OnPropertyChanged("temperatureSensorState");
        }
        public void TurnOff()
        {
            isOn = turnOffTemperatureSensor.TurnOffDevice();
            temperatureSensorState = TEMPERATURE_SENSOR_OFF;
            OnPropertyChanged("temperatureSensorState");
        }
    }
}