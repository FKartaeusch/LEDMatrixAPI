using System;

namespace Engine.Models
{
    public class State
    {
        public DateTime CancelDate;
        public DateTime CreateDate;
        public StateCode NextState;
        public StateCode StateCode;
        public int Time;
    }

    public enum StateCode
    {
        TestConnection,
        ShowClock,
        Message,
        Off,
        Weather
    }
}