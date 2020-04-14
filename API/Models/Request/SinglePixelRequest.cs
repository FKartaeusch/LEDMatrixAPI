using System;

namespace API.Models.Request
{
    [Serializable]
    public class SinglePixelRequest
    {
        public bool ClearImage { get; set; }
        public int PixelNumber { get; set; }

        public int Alpha { get; set; }
        public int Red { get; set; }
        public int Blue { get; set; }
        public int Green { get; set; }
    }
}