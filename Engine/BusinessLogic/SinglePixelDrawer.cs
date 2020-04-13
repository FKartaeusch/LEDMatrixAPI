using System;
using System.Drawing;
using Engine.Core;
using Engine.Models.DTO;
using IconsAndFonts.Icons;

namespace Engine.BusinessLogic
{
    public class SinglePixelDrawer : IDrawSinglePixel
    {
        private readonly IDeviceConnector _connector;

        public SinglePixelDrawer(IDeviceConnector connector)
        {
            _connector = connector;
        }

        public void Draw(SinglePixelDTO pixelDTO)
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