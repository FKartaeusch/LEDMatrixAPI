using System;
using System.Device.Spi;
using System.Drawing;
using System.Threading;
using IconsAndFonts.Icons;
using Iot.Device.Ws28xx;

namespace Engine.Core
{
    public class SimpleTestConnector : ITestConnector
    {
        public void TestConnection()
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

                var image = device.Image;
                image.Clear();

                var icon = new HeartIcon(Color.Crimson);
                foreach (var pixel in icon.Pixels) image.SetPixel(pixel.x, pixel.y, pixel.color);
                device.Update();
                Thread.Sleep(5000);
                image.Clear();
                device.Update();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}