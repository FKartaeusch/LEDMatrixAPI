namespace Engine.Models.DTO
{
    public class StateDTO
    {
        public StateCode NextState = StateCode.ShowClock;
        public StateCode StateCode;
        public int Time;
    }
}