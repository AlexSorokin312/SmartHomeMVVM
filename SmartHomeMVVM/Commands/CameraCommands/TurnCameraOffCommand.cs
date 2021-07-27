using SmartHomeMVVM.Models.Devices;

namespace SmartHomeMVVM.Commands.CameraCommands
{
    class TurnCameraOffCommand : CommandBase
    {
        Camera camera;

        public TurnCameraOffCommand(Camera camera)
        {
            this.camera = camera;
        }

        public override void Execute(object parameter)
        {
            camera.TurnCameraOff();
        }
    }
}
