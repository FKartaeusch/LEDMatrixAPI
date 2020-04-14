using Engine.Models;
using Engine.Models.DTO;

namespace Engine.Core
{
    public class SimpleStateHandler : IStateHandler
    {
        private static State currentState;


        public State GetCurrentState()
        {
            if (currentState == null)
            {
                currentState = CreateState();
            }

            return currentState;
        }

        public void SetState(StateDTO dto)
        {
            currentState.StateCode = dto.StateCode;
            currentState.Time = dto.Time;
        }

        public void ChangeState(StateDTO dto)
        {
        }

        private static State CreateState()
        {
            var state = new State();
            state.StateCode = StateCode.ShowClock;
            return state;
        }
    }
}