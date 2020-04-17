using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using Engine.BusinessLogic.DrawLogic;
using Engine.Core;
using Engine.Models;
using Engine.Models.DTO;
using IconsAndFonts.Fonts;
using IconsAndFonts.Fonts.TryOutFont;

namespace Engine.BusinessLogic.ClockLogic
{
    public class SimpleClockLogic : IClockLogic
    {
        private const int TopRowSpace = 2;
        private const int HourCol1 = 8;
        private const int HourCol2 = 13;
        private const int ColonCol = 17;
        private const int MinuteCol1 = 19;
        private const int MinuteCol2 = 23;
        private readonly IDrawSinglePixel _drawer;
        private readonly IStateHandler _stateHandler;

        public SimpleClockLogic(IDrawSinglePixel drawer, IStateHandler stateHandler)
        {
            _drawer = drawer;
            _stateHandler = stateHandler;
        }

        public void ShowClock(Color color)
        {
            var font = new PixelFont(new TryOutLetters(), new TryOutNumbers(color), new TryOutSpecialSigns(color));
            var cultureInfo = CultureInfo.CreateSpecificCulture("de-DE");
            while (true)
            {
                var time = DateTime.Now.ToString("t", cultureInfo);

                if (_stateHandler.GetCurrentState().StateCode != StateCode.ShowClock)
                {
                    break;
                }

                Console.WriteLine(time);
                for (var i = 0; time.Length > i; i++)
                {
                    int spaceTop = TopRowSpace, spaceLeft = GetColSpace(i);
                    PrintPixelFont(MapStringToPixel(font, time[i].ToString()), spaceTop, spaceLeft);
                }

                Thread.Sleep(1000);
            }
        }

        private int GetColSpace(int i)
        {
            if (i == 0)
            {
                return HourCol1;
            }

            if (i == 1)
            {
                return HourCol2;
            }

            if (i == 2)
            {
                return ColonCol;
            }

            if (i == 3)
            {
                return MinuteCol1;
            }

            if (i == 4)
            {
                return MinuteCol2;
            }

            return 0;
        }

        private void PrintPixelFont(BaseFont symbolToPrint, int spaceTopRows, int colSpaceLeft)
        {
            foreach (var pixel in symbolToPrint.pixels)
            {
                _drawer.Draw(new SinglePixelDTO
                {
                    Color = pixel.Color,
                    PixelLocation = new PixelLocationDTO
                    {
                        Col = pixel.Col + colSpaceLeft,
                        Row = pixel.Row + spaceTopRows
                    }
                });
            }
        }

        private BaseFont MapStringToPixel(PixelFont pixelfont, string stringToMap)
        {
            switch (stringToMap)
            {
                case "0":
                    return pixelfont.Numbers.zero;
                case "1":
                    return pixelfont.Numbers.one;
                case "2":
                    return pixelfont.Numbers.two;
                case "3":
                    return pixelfont.Numbers.three;
                case "4":
                    return pixelfont.Numbers.four;
                case "5":
                    return pixelfont.Numbers.five;
                case "6":
                    return pixelfont.Numbers.six;
                case "7":
                    return pixelfont.Numbers.seven;
                case "8":
                    return pixelfont.Numbers.eight;
                case "9":
                    return pixelfont.Numbers.nine;
                case ":":
                    return pixelfont.SpecialSigns.colon;
                default:
                    return null;
            }
        }
    }
}