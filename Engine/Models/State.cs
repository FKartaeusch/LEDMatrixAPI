using System;

namespace Engine.Models
{
    public class State
    {
        public DateTime CancelDate;
        public DateTime CreateDate;
        public StateCode StateCode;
        public int Time;
    }

    public enum StateCode
    {
        ShowClock,
        Message,
        Off,
        Weather
    }
}