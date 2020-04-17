﻿using System;
using System.Drawing;
using System.Threading;
using IconsAndFonts.Icons;
using Iot.Device.Ws28xx;

namespace Engine.Core.Connection
{
    public class SimpleTestConnector : ITestConnector
    {
        private readonly IDeviceConnector _connector;

        public SimpleTestConnector(IDeviceConnector connector)
        {
            _connector = connector;
        }

        public void TestConnection()
        {
            try
            {
                DrawTest(_connector.GetDevice());
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
            var fadeOut = false;
            while (true)
            {
                var b = 1;
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

                Thread.Sleep(200);
                fadeOut = false;
            }
        }
    }
}