using System;

namespace API.Models.Request
{
    [Serializable]
    public class SinglePixelRequest
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int Red { get; set; }
        public int Blue { get; set; }
        public int Green { get; set; }
    }
}