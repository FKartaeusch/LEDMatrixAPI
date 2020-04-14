using System;
using System.Drawing;
using System.Threading;
using Engine.Core.Connection;
using Engine.DeviceUtils.LEDMatrixWS2812B;
using Engine.Models.DTO;
using IconsAndFonts.Icons;

namespace Engine.BusinessLogic.DrawLogic
{
    public class OldSinglePixelDrawer : IOldDrawSinglePixel
    {
        private readonly IDeviceConnector _connector;
        private readonly IPixelPointer _pixelPointer;

        public OldSinglePixelDrawer(IDeviceConnector connector, IPixelPointer pointer)
        {
            _pixelPointer = pointer;
            _connector = connector;
        }

        public void Draw(OldSinglePixelDTO pixelDTO)
        {
            var device = _connector.GetDevice();
            var image = device.Image;
            if (pixelDTO.ClearImage)
            {
                device.Image.Clear();
                device.Update();
            }

            image.SetPixel(pixelDTO.PixelNumber, 0, Color.Blue);
            device.Update();
        }

        public void Draw(PixelInformation pixel)
        {
            throw new NotImplementedException();
        }
    }
}