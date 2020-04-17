using System;
using System.Drawing;
using Engine.BusinessLogic.ClockLogic;
using Engine.Core.Connection;
using Engine.Core.Threading;
using Engine.Models;
using Engine.Models.DTO;

namespace Engine.Core
{
    public class SimpleStateHandler : IStateHandler
    {
        private static State currentState;
        private readonly IClockLogic _clockLogic;
        private readonly ITestConnector _testConnector;
        private readonly IThreadHandler _threadHandler;

        public SimpleStateHandler(IThreadHandler threadHandler, IClockLogic clockLogic, ITestConnector testConnector)
        {
            _threadHandler = threadHandler;
            _clockLogic = clockLogic;
            _testConnector = testConnector;
        }


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
            currentState.NextState = dto.NextState;
            var action = StateActionMapper(currentState.StateCode);

            if (action != null)
            {
                _threadHandler.StartThread(action);
            }
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

        private Action StateActionMapper(StateCode stateCode)
        {
            if (stateCode == StateCode.ShowClock)
            {
                return delegate { _clockLogic.ShowClock(Color.FromArgb(0xff, 50, 50, 50)); };
            }

            if (stateCode == StateCode.TestConnection)
            {
                return delegate { _testConnector.TestConnection(); };
            }

            return null;
        }
    }
}