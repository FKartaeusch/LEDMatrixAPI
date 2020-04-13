using System.Collections.Generic;
using IconsAndFonts.Animations;

namespace IconsAndFonts.Icons
{
    public abstract class BaseIcon
    {
        public AnimationStyle AnimationStyle;
        public bool ClearAfter;
        public bool ClearBefore;
        public List<PixelInformation> Pixels;
    }
}