using Engine.Core;
using Engine.Core.Connection;
using Engine.Models;
using Engine.Models.DTO;

namespace Engine.BusinessLogic.ResetLogic
{
    public class ResetLogic : IResetLogic
    {
        private readonly IDeviceConnector _connector;
        private readonly IStateHandler _stateHandler;

        public ResetLogic(IDeviceConnector deviceConnector, IStateHandler stateHandler)
        {
            _stateHandler = stateHandler;
            _connector = deviceConnector;
        }

        public void Reset()
        {
            _stateHandler.SetState(new StateDTO
            {
                Time = 10,
                StateCode = StateCode.ShowClock
            });
            var device = _connector.GetDevice();
            device.Image.Clear();
            device.Update();
        }
    }
}