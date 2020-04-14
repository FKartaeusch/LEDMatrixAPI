﻿using System;
using System.Device.Spi;
using System.Drawing;
using System.Threading;
using IconsAndFonts.Icons;
using Iot.Device.Ws28xx;

namespace Engine.Core.Connection
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
            var fadeOut = false;
            for (int i = 0; i < 2; i++)
            {
                while (b > 0)
                {
                    foreach (var pixel in heart.Pixels)
                    {
                        image.SetPixel(pixel.x, pixel.y, Color.FromArgb(0xff, b, 0, 0));
                    }

                    device.Update();
                    Thread.Sleep(10);
                    if (fadeOut)
                    {
                        b--;
                    }
                    else
                    {
                        b++;
                        if (b == 120)
                        {
                            fadeOut = true;
                        }
                    }
                }
                Thread.Sleep(500);
                fadeOut = false;
            }

            image.Clear();
            device.Update();
            
        }
    }
}