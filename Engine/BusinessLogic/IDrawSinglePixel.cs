using Engine.Models.DTO;
using IconsAndFonts.Icons;

namespace Engine.BusinessLogic
{
    public interface IDrawSinglePixel
    {
        public void Draw(PixelInformation pixel);

        public void Draw(SinglePixelDTO pixelDTO);
    }
}