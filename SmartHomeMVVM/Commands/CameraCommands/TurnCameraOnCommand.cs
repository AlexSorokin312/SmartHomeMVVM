using SmartHomeMVVM.Models.Devices;

namespace SmartHomeMVVM.Commands
{
    class TurnCameraOnCommand : CommandBase
    {
        Camera camera;

        public TurnCameraOnCommand(Camera camera)
        {
            this.camera = camera;
        }

        public override void Execute(object parameter)
        {
            camera.TurnCameraOn();
        }
    }
}
