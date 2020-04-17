using Engine.Models;
using Engine.Models.DTO;

namespace Engine.Core
{
    public class SimpleStateHandler : IStateHandler
    {
        private static State _currentState;


        public State GetCurrentState()
        {
            if (_currentState == null)
            {
                _currentState = CreateState();
            }

            return _currentState;
        }

        public void SetState(StateDTO dto)
        {
            var currentState = GetCurrentState();
            currentState.StateCode = dto.StateCode;
            currentState.Time = dto.Time;
            currentState.NextState = dto.NextState;
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