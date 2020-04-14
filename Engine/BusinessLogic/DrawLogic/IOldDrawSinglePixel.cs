using Engine.Models.DTO;
using IconsAndFonts.Icons;

namespace Engine.BusinessLogic.DrawLogic
{
    public interface IOldDrawSinglePixel
    {
        public void Draw(PixelInformation pixel);

        public void Draw(OldSinglePixelDTO pixelDTO);
    }
}