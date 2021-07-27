using SmartHomeMVVM.Models.Devices;

namespace SmartHomeMVVM.Commands
{
    class TurnOffMovementSensorCommand : CommandBase
    {
        Camera camera;
        public TurnOffMovementSensorCommand(Camera camera)
        {
            this.camera = camera;
        }

        public override void Execute(object parameter)
        {
            camera.TurnOffMovementSenseor();
        }
    }
}
