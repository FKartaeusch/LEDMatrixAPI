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
                DrawTest(device);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void DrawTest(Ws2812b device)
        {
            var image = device.Image;
            image.Clear();

            var heart = new HeartIcon(Color.Crimson);
            var b = 1;
            while (b > 0)
            {
                heart.UpdateColor(Color.FromArgb(b, Color.Crimson));
                foreach (var pixel in heart.Pixels)
                {
                    image.SetPixel(pixel.x, pixel.y, Color.FromArgb(0xff, b, b, b));
                }

                device.Update();
                Thread.Sleep(10);
                if (b < 150)
                {
                    b++;
                }
                else
                {
                    b--;
                }
            }

            image.Clear();
            device.Update();
        }
    }
}