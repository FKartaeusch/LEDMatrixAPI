using System;
using System.Device.Spi;
using Engine.Core.Connection;
using Engine.DeviceUtils.LEDMatrixWS2812B;
using Engine.Models.DTO;
using IconsAndFonts.Icons;
using Iot.Device.Ws28xx;

namespace Engine.BusinessLogic.DrawLogic
{
    public class SinglePixelDrawer : IDrawSinglePixel
    {
        private readonly IDeviceConnector _connector;
        private readonly IPixelPointer _pixelPointer;

        public SinglePixelDrawer(IDeviceConnector connector, IPixelPointer pointer)
        {
            _pixelPointer = pointer;
            _connector = connector;
        }

        public void Draw(SinglePixelDTO pixelDTO)
        {
            var count = 256; // number of LEDs
            var settings = new SpiConnectionSettings(0, 0)
            {
                ClockFrequency = 2_400_000, Mode = SpiMode.Mode0, DataBitLength = 8
            };

            var spi = SpiDevice.Create(settings);
            var device = new Ws2812b(spi, count);
            //var device = _connector.GetDevice();
            var pixelAdress = _pixelPointer.GetDevicePixel(pixelDTO.PixelLocation);
            Console.WriteLine("Adressing Pixel " + pixelAdress);
            device.Image.SetPixel(pixelAdress, 0, pixelDTO.Color);
            device.Update();
        }

        public void Draw(PixelInformation pixel)
        {
            throw new NotImplementedException();
        }
    }
}