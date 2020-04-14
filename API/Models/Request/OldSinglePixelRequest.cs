using System;

namespace API.Models.Request
{
    [Serializable]
    public class OldSinglePixelRequest
    {
        public bool ClearImage { get; set; }
        public int PixelNumber { get; set; }
    }
}