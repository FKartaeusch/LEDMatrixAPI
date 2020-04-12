using System.Device.Spi;
using System.Drawing;
using System.Threading;
using Iot.Device.Ws28xx;

namespace Engine.Core
{
    public class SimpleTestConnector : ITestConnector
    {
        public bool TestConnection()
        {
            try
            {
                var count = 256; // number of LEDs
                var settings = new SpiConnectionSettings(0, 0)
                {
                    ClockFrequency = 2_400_000,
                    Mode = SpiMode.Mode0,
                    DataBitLength = 8
                };

                var spi = SpiDevice.Create(settings);
                var device = new Ws2812b(spi, count);

                var image = device.Image;
                image.Clear();
                image.SetPixel(0, 0, Color.Orange);
                device.Update();
                Thread.Sleep(5000);
                image.Clear();


                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}