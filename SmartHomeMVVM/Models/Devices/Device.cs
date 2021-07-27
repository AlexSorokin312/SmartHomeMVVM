
using SmartHomeMVVM.Models.Devices.ITemperature;
using System.ComponentModel;

namespace SmartHomeMVVM.Models.Devices
{
    abstract class Device
    {
        public string _name;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        protected IChangeTemperature increaseTemperature;
        protected IChangeTemperature decreaseTemperature;
        protected IChangeTemperature setTemperatyreToDefault;

        public Device(string name)
        {
            _name = name;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}