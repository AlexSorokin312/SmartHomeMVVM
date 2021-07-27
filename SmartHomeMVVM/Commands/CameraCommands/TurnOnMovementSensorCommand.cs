using SmartHomeMVVM.Models.Devices;

namespace SmartHomeMVVM.Commands
{
    class TurnOnMovementSensorCommand : CommandBase
    {
        Camera camera;
        public TurnOnMovementSensorCommand(Camera camera)
        {
            this.camera = camera;
        }

        public override void Execute(object parameter)
        {
            camera.TurnOnMovementSenseor();
        }
    }

}