using SmartHomeMVVM.Models.Devices.ITemperature;
using SmartHomeMVVM.Models.Devices.ITurnOnDevice;
using SmartHomeMVVM.Models.Devices.ITurnOffDevice;
using System.ComponentModel;

namespace SmartHomeMVVM.Models.Devices
{
    class Boiler : Device, INotifyPropertyChanged
    {
        public const int INITIAL_TEMPERATURE = 10;
        public const string BOILER_ON= "Котёл включен";
        public const string BOILER_OFF = "Котёл выключен";
        private const int DEGREE = 1;
        public int boilerTemperature { get; set; }
        private bool isOn { get; set; }

        public string boilerState { get; set; }

        ITurnOn turnOnBoiler;
        ITurnOff turnOffBoiler;
        public Boiler(string name) : base(name)
        {
            isOn = false;
            boilerState = BOILER_OFF;
            boilerTemperature = INITIAL_TEMPERATURE;
            turnOnBoiler = new TurnOn();
            turnOffBoiler = new TurnOff();
            increaseTemperature = new IncreaseTemperature();
            decreaseTemperature = new DecreaseTemperature();
            setTemperatyreToDefault = new SetTemperatureToDefault();
        }

        public void TurnOn()
        {
            isOn = turnOnBoiler.TurnOnDevice();
            boilerState = BOILER_ON;
            OnPropertyChanged("boilerState");
        }

        public void TurnOff()
        {
            isOn = turnOffBoiler.TurnOffDevice();
            boilerState = BOILER_OFF;
            OnPropertyChanged("boilerState");
        }

        public void IncreaseTemperatureByOneDegree()
        {
            boilerTemperature = increaseTemperature.changeTemperature(boilerTemperature, DEGREE);
            OnPropertyChanged("boilerTemperature");
        }

        public void DecreaseTemperatureByOneDegree()
        {
            boilerTemperature = decreaseTemperature.changeTemperature(boilerTemperature, DEGREE);
            OnPropertyChanged("boilerTemperature");
        }

        public void SetTenperatureToDefault()
        {
            boilerTemperature = setTemperatyreToDefault.changeTemperature(boilerTemperature, 0);
            OnPropertyChanged("boilerTemperature");
        }

    }
}
