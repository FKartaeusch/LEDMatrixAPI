using System;
using System.Device.Spi;
using Iot.Device.Ws28xx;

namespace Engine.Core.Connection
{
    public sealed class StaticConnector : IDeviceConnector
    {
        private static Ws2812b instance;

        private Ws2812b Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = CreateInstance();
                }
                return instance;
            }
        }

        public Ws2812b GetDevice()
        {
            return Instance;
        }

        private static Ws2812b CreateInstance()
        {
            try
            {
                var count = 256; // number of LEDs
                var settings = new SpiConnectionSettings(0, 0)
                {
                    ClockFrequency = 2_400_000, Mode = SpiMode.Mode0, DataBitLength = 8
                };

                var spi = SpiDevice.Create(settings);
                var device = new Ws2812b(spi, count);
                device.Image.Clear();
                device.Update();
                return device;
            }
            catch (Exception ex)
            {
                // Log error
                //throw new Exception("Error connecting to the LED matrix");
                throw ex;
            }
        }
    }
}