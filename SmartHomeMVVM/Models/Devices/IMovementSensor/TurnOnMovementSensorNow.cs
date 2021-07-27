﻿
namespace SmartHomeMVVM.Models.Devices.ITemperature
{
    class TurnOnSensorNow : IMovementSensorTurnOn
    {
        Camera _camera;
        public TurnOnSensorNow(Camera camera)
        {
            _camera = camera;
        }

        public void TurnOnMovementSensor()
        {
            _camera._isSensorMovementOn = true;
        }
    }
}
