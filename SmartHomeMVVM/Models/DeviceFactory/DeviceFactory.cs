﻿using SmartHomeMVVM.Models.Devices;

namespace SmartHomeMVVM.Models.DeviceFactory
{

    enum DeviceType{
        Camera,
        Boiler,
        TemperatureSensor
    }

    class DevicesFactory
    {
        public Device createDevice(DeviceType deviceType, string name)
        {
            switch (deviceType)
            {
                case DeviceType.Camera:
                    return new Camera(name);
                case DeviceType.Boiler:
                    return new Boiler(name);
               case DeviceType.TemperatureSensor:
                     return new TemperatureSensor(name);
                default:
                    return null;
            }
        }

    }
}
