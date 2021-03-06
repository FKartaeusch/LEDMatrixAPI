﻿using Engine.Core.Connection;
using Engine.DeviceUtils.LEDMatrixWS2812B;
using Engine.Models.DTO;

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
            image.SetPixel(pixelAdress, 0, pixelDTO.Color);
            device.Update();
        }
    }
}