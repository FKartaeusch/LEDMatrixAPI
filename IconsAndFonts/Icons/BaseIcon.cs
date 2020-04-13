using System.Collections.Generic;
using System.Drawing;
using IconsAndFonts.Animations;

namespace IconsAndFonts.Icons
{
    public abstract class BaseIcon
    {
        public AnimationStyle AnimationStyle;
        public bool ClearAfter;
        public bool ClearBefore;
        public List<PixelInformation> Pixels;

        public void UpdateColor(Color color)
        {
            Pixels.ForEach(p => p.color = color);
        }
    }
}