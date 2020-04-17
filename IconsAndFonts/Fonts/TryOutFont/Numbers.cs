using System.Drawing;
using IconsAndFonts.Fonts.Base;

namespace IconsAndFonts.Fonts.TryOutFont
{
    public class TryOutNumbers : BaseNumbers
    {
        public TryOutNumbers(Color color)
        {
            zero = new Zero(color);
            one = new One(color);
            two = new Two(color);
            three = new Three(color);
            four = new Four(color);
            five = new Five(color);
            six = new Six(color);
            seven = new Seven(color);
            eight = new Eight(color);
            nine = new Nine(color);
        }


        public class Zero : BaseZero
        {
            public Zero(Color color)
            {
                pixels.Add(new FontPixelInformation
                {
                    Row = 1,
                    Col = 0,
                    Color = color
                });

                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 3,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 3,
                    Col = 3,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 3,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 3,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 2,
                    Color = color
                });
            }
        }

        public class One : BaseOne
        {
            public One(Color color)
            {
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 2,
                    Color = color
                });

                pixels.Add(new FontPixelInformation
                {
                    Row = 1,
                    Col = 2,
                    Color = color
                });

                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 3,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 2,
                    Color = color
                });
            }
        }

        public class Two : BaseTwo
        {
            public Two(Color color)
            {
                pixels.Add(new FontPixelInformation
                {
                    Row = 1,
                    Col = 0,
                    Color = color
                });

                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 0,
                    Color = color
                });

                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 3,
                    Color = color
                });


                pixels.Add(new FontPixelInformation
                {
                    Row = 3,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 1,
                    Col = 3,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 2,
                    Color = color
                });
            }
        }

        public class Three : BaseThree
        {
            public Three(Color color)
            {
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 1,
                    Color = color
                });

                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 2,
                    Color = color
                });

                pixels.Add(new FontPixelInformation
                {
                    Row = 1,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 3,
                    Col = 2,
                    Color = color
                });

                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 2,
                    Color = color
                });
            }
        }

        public class Four : BaseFour
        {
            public Four(Color color)
            {
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 1,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 3,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 3,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 3,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 2,
                    Color = color
                });
            }
        }

        public class Five : BaseFive
        {
            public Five(Color color)
            {
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 1,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 2,
                    Color = color
                });

                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 3,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 2,
                    Color = color
                });
            }
        }

        public class Six : BaseSix
        {
            public Six(Color color)
            {
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 1,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 3,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 1,
                    Color = color
                });


                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 3,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 2,
                    Color = color
                });
            }
        }

        public class Seven : BaseSeven
        {
            public Seven(Color color)
            {
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 1,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 3,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 2,
                    Color = color
                });
            }
        }

        public class Eight : BaseEight
        {
            public Eight(Color color)
            {
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 1,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 1,
                    Col = 3,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 3,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 3,
                    Col = 3,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 2,
                    Color = color
                });
            }
        }

        public class Nine : BaseNine
        {
            public Nine(Color color)
            {
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 0,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 1,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 1,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 2,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 3,
                    Col = 2,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 0,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 1,
                    Color = color
                });
                pixels.Add(new FontPixelInformation
                {
                    Row = 4,
                    Col = 2,
                    Color = color
                });
            }
        }
    }
}