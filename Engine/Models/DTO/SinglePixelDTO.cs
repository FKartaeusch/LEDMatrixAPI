using System.Drawing;
using IconsAndFonts.Animations;

namespace Engine.Models.DTO
{
    public class SinglePixelDTO
    {
        public AnimationStyle AnimationStyle = AnimationStyle.SIMPLE;
        public Color Color;
        public PixelLocationDTO PixelLocation;
    }
}