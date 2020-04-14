using System;
using System.Device.Spi;
using Iot.Device.Ws28xx;

namespace Engine.Core.Connection
{
    public sealed class StaticConnector : IDeviceConnector
    {
        private Ws2812b instance;


        public Ws2812b GetDevice()
        {
            if (instance == null)
            {
                instance = CreateInstance();
            }

            // Refresh connection?
            instance.Update();

            return instance;
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
                return new Ws2812b(spi, count);
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