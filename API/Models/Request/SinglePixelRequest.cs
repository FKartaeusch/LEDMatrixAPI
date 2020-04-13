using System;

namespace API.Models.Request
{
    [Serializable]
    public class SinglePixelRequest
    {
        public bool ClearImage { get; set; }
        public int PixelNumber { get; set; }
    }
}