using System;
using Engine.Models.DTO;

namespace Engine.DeviceUtils.LEDMatrixWS2812B
{
    public class ArrayPixelPointer : IPixelPointer
    {
        private readonly int[,] MainArray = new int[8, 32];

        private readonly Tuple<int, int>[] rowRanges =
        {
            // row 1
            new Tuple<int, int>(0, 31),
            // row 2
            new Tuple<int, int>(63, 32),
            // row 3
            new Tuple<int, int>(64, 95),
            // row 4
            new Tuple<int, int>(127, 96),
            // row 5
            new Tuple<int, int>(128, 159),
            // row 6
            new Tuple<int, int>(191, 160),
            // row 7
            new Tuple<int, int>(192, 223),
            // row 8
            new Tuple<int, int>(255, 224)
        };

        public ArrayPixelPointer()
        {
            var row = 0;
            foreach (var rowRange in rowRanges)
            {
                InitializeRow(rowRange, row);
                row++;
            }
        }

        public int GetDevicePixel(PixelLocationDTO dto)
        {
            return MainArray[dto.Row, dto.Col];
        }

        private void InitializeRow(Tuple<int, int> range, int row)
        {
            int col = 0, index = range.Item1;

            if (range.Item1 < range.Item2)
            {
                for (; index <= range.Item2; index++)
                {
                    MainArray[row, col] = index;
                    col++;
                }
            }
            else
            {
                for (; index <= range.Item2; index--)
                {
                    MainArray[row, col] = index;
                    col++;
                }
            }
        }
    }
}