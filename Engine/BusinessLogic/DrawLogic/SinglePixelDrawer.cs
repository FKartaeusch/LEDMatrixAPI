using System;
using System.Threading;
using Engine.Core.Connection;
using Engine.DeviceUtils.LEDMatrixWS2812B;
using Engine.Models.DTO;
using IconsAndFonts.Icons;

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
            var device = _connector.GetDevice();
            var image = device.Image;
            var pixelAdress = _pixelPointer.GetDevicePixel(pixelDTO.PixelLocation);
            Console.WriteLine("Adressing Pixel " + pixelAdress);
            image.SetPixel(pixelAdress, 0, pixelDTO.Color);
            Thread.Sleep(100);
            device.Update();
        }

        public void Draw(PixelInformation pixel)
        {
            throw new NotImplementedException();
        }
    }
}