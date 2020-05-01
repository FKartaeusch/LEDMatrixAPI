using System;
using System.Drawing;

namespace Engine.Models
{
    public class State
    {
        public DateTime CancelDate;
        public Color color;
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