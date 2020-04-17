﻿using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using Engine.BusinessLogic.DrawLogic;
using Engine.BusinessLogic.ResetLogic;
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
        private const int HourCol1 = 5;
        private const int HourCol2 = HourCol1 + 5;
        private const int ColonCol = HourCol2 + 5;
        private const int MinuteCol1 = ColonCol + 2;
        private const int MinuteCol2 = MinuteCol1 + 5;
        private readonly IDrawSinglePixel _drawer;
        private readonly IResetLogic _resetLogic;
        private readonly IStateHandler _stateHandler;

        public SimpleClockLogic(IDrawSinglePixel drawer, IStateHandler stateHandler, IResetLogic resetLogic)
        {
            _drawer = drawer;
            _stateHandler = stateHandler;
            _resetLogic = resetLogic;
        }

        public void ShowClock(Color color)
        {
            var font = new PixelFont(new TryOutLetters(), new TryOutNumbers(color), new TryOutSpecialSigns(color));
            var cultureInfo = CultureInfo.CreateSpecificCulture("de-DE");
            var oldTime = string.Empty;
            while (true)
            {
                var time = DateTime.Now.ToString("t", cultureInfo);
                if (time.Equals(oldTime))
                {
                    Thread.Sleep(5000);
                    continue;
                }

                if (_stateHandler.GetCurrentState().StateCode != StateCode.ShowClock)
                {
                    break;
                }

                _resetLogic.Reset();
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

        private void RemoveOldPixels()
        {
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