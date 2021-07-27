using SmartHomeMVVM.Models.Devices.ITemperature;
using SmartHomeMVVM.Models.Devices.ITurnOffDevice;
using SmartHomeMVVM.Models.Devices.ITurnOnDevice;
using System.ComponentModel;

namespace SmartHomeMVVM.Models.Devices
{
    class Camera : Device, INotifyPropertyChanged
    {
        private const string CAMERA_ON = "Камера включена";
        private const string CAMERA_OFF = "Камера выключена";
        private const string MOVEMENT_SENSOR_ON = "Датчик движения включен";
        private const string MOVEMENT_SENSOR_OFF = "Датчик движения выключен";

        ITurnOn turnOnCamera;
        ITurnOff turnOffCamera;
        IMovementSensorTurnOn turnOnSensorBehaviour;
        IMovementSensorTurnOff turnOffSensorBehaviour;

        private bool isOn { get; set; }
        public string cameraState { get; set; }
        public string movementSensorState { get; set; }

        public bool _isSensorMovementOn;
        public bool IsSensorMovementOn
        {
            get
            {
                return _isSensorMovementOn;
            }
            set
            {
                _isSensorMovementOn = value;
            }
        }
        public Camera(string name) : base(name)
        {
            _isSensorMovementOn = false;
             turnOnCamera = new TurnOn();
             turnOffCamera = new TurnOff();
            turnOnSensorBehaviour = new TurnOnSensorNow(this);
            turnOffSensorBehaviour = new TurnOffSensorNow(this);
            cameraState = CAMERA_OFF;
            movementSensorState = MOVEMENT_SENSOR_OFF;
        }
        public void TurnCameraOn()
        {
            isOn = turnOnCamera.TurnOnDevice();
            cameraState = CAMERA_ON;
            OnPropertyChanged("cameraState");
        }

        public void TurnCameraOff()
        {
            isOn = turnOffCamera.TurnOffDevice();
            cameraState = CAMERA_OFF;
            OnPropertyChanged("cameraState");
        }

        public void TurnOnMovementSenseor()
        {  
            turnOnSensorBehaviour.TurnOnMovementSensor();
            movementSensorState = MOVEMENT_SENSOR_ON;
            OnPropertyChanged("movementSensorState");
        }

        public void TurnOffMovementSenseor()
        {
            turnOffSensorBehaviour.TurnOffMovementSensor();
            movementSensorState = MOVEMENT_SENSOR_OFF;
            OnPropertyChanged("movementSensorState");
        }
    }
}
