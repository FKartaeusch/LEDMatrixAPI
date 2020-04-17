using System;
using System.Drawing;
using System.Threading;
using Engine.BusinessLogic.ClockLogic;
using Engine.Core.Connection;
using Engine.Models;

namespace Engine.Core.Threading
{
    public class MainThreadHandler : IThreadHandler
    {
        private static Thread _currentThread;
        private readonly IClockLogic _clockLogic;
        private readonly IStateHandler _stateHandler;
        private readonly ITestConnector _testConnector;

        public MainThreadHandler(IClockLogic clockLogic, ITestConnector testConnector, IStateHandler stateHandler)
        {
            _stateHandler = stateHandler;
            _clockLogic = clockLogic;
            _testConnector = testConnector;
        }

        public void StartThread()
        {
            var currentState = _stateHandler.GetCurrentState();
            var action = StateActionMapper(currentState.StateCode);
            var currentThread = GetCurrentThread(action);
            currentThread.Start();
        }

        public void StopThread()
        {
            throw new NotImplementedException();
        }

        private Thread GetCurrentThread(Action action)
        {
            if (_currentThread != null && _currentThread.IsAlive)
            {
                // Abort!
            }

            var start = new ThreadStart(action);
            _currentThread = new Thread(start);

            return _currentThread;
        }

        private Action StateActionMapper(StateCode stateCode)
        {
            if (stateCode == StateCode.ShowClock)
            {
                return delegate { _clockLogic.ShowClock(Color.FromArgb(0xff, 30, 30, 30)); };
            }

            if (stateCode == StateCode.TestConnection)
            {
                return delegate { _testConnector.TestConnection(); };
            }

            return null;
        }
    }
}