using System.Collections.Generic;

namespace IconsAndFonts.Fonts
{
    public abstract class BaseFont
    {
        public List<FontPixelInformation> pixels;

        protected BaseFont()
        {
            pixels = new List<FontPixelInformation>();
        }
    }
}