using System;
using System.Drawing;
using IconsAndFonts.Animations;

namespace API.Models.Request
{
    [Serializable]
    public class SinglePixelRequest
    {
        public AnimationStyle AnimationStyle = AnimationStyle.SIMPLE;
        public bool ClearImage = false;
        public Color Color = Color.Orange;
        public int pixelNumber;
    }
}