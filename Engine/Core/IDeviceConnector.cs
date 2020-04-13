using Iot.Device.Ws28xx;

namespace Engine.Core
{
    public interface IDeviceConnector
    {
        public Ws2812b GetDevice();
    }
}