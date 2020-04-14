using Iot.Device.Ws28xx;

namespace Engine.Core.Connection
{
    public interface IDeviceConnector
    {
        public Ws2812b GetDevice();
    }
}