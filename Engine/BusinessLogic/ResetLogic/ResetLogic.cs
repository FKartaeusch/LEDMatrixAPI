using Engine.Core.Connection;

namespace Engine.BusinessLogic.ResetLogic
{
    public class ResetLogic : IResetLogic
    {
        private readonly IDeviceConnector _connector;

        public ResetLogic(IDeviceConnector deviceConnector)
        {
            _connector = deviceConnector;
        }

        public void Reset()
        {
            var device = _connector.GetDevice();
            device.Image.Clear();
            device.Update();
        }
    }
}