using System.Drawing;
using IconsAndFonts.Fonts.Base;

namespace IconsAndFonts.Fonts.TryOutFont
{
    public class TryOutSpecialSigns : BaseSpecialSigns
    {
        public TryOutSpecialSigns(Color color)
        {
            colon = new Colon(color);
            point = new Point(color);
        }

        public class Colon : BaseColon
        {
            public Colon(Color color)
            {
                pixels.Add(new FontPixelInformation
                {
                    Row = 1,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 3,
                    Col = 0,
                    Color = color
                });
            }
        }

        public class Point : BasePoint
        {
            public Point(Color color)
            {
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 0,
                    Color = color
                });
            }
        }
    }
}