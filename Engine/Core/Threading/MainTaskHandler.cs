using System;
using System.Drawing;
using System.Threading.Tasks;
using Engine.BusinessLogic.ClockLogic;
using Engine.Core.Connection;
using Engine.Models;

namespace Engine.Core.Threading
{
    public class MainTaskHandler : IThreadHandler
    {
        private static Task _currentTask;
        private readonly ICancelHandler _cancelHandler;
        private readonly IClockLogic _clockLogic;
        private readonly IStateHandler _stateHandler;
        private readonly ITestConnector _testConnector;

        public MainTaskHandler(IClockLogic clockLogic, ITestConnector testConnector, IStateHandler stateHandler,
            ICancelHandler cancelHandler)
        {
            _stateHandler = stateHandler;
            _clockLogic = clockLogic;
            _testConnector = testConnector;
            _cancelHandler = cancelHandler;
        }

        public void StartThread()
        {
            var currentState = _stateHandler.GetCurrentState();
            var action = StateActionMapper(currentState.StateCode);
            var currentTask = GetCurrentTask(action);

            currentTask.Start();
        }

        public void StopThread()
        {
            throw new NotImplementedException();
        }

        private Task GetCurrentTask(Action action)
        {
            if (_currentTask != null && _currentTask.Status == TaskStatus.Running)
            {
                _cancelHandler.Cancel();
            }

            _currentTask = new Task(action);

            return _currentTask;
        }

        private Action StateActionMapper(StateCode stateCode)
        {
            if (stateCode == StateCode.ShowClock)
            {
                return delegate { _clockLogic.ShowClock(Color.FromArgb(0xff, 25, 25, 25)); };
            }

            if (stateCode == StateCode.TestConnection)
            {
                return delegate { _testConnector.TestConnection(); };
            }

            return null;
        }
    }
}