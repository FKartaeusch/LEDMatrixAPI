using System;
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

            image.SetPixel(_pixelPointer.GetDevicePixel(pixelDTO.PixelLocation), 0, pixelDTO.Color);
            device.Update();
        }

        public void Draw(PixelInformation pixel)
        {
            throw new NotImplementedException();
        }
    }
}