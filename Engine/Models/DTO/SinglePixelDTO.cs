using System.Drawing;
using IconsAndFonts.Animations;

namespace Engine.Models.DTO
{
    public class SinglePixelDTO
    {
        public AnimationStyle AnimationStyle = AnimationStyle.SIMPLE;
        public bool ClearImage = false;
        public Color Color;
        public int PixelNumber;
    }
}