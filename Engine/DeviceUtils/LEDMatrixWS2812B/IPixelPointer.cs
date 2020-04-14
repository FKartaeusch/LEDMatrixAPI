using Engine.Models.DTO;

namespace Engine.DeviceUtils.LEDMatrixWS2812B
{
    public interface IPixelPointer
    {
        public int GetDevicePixel(PixelLocationDTO dto);
    }
}