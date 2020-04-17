using System;
using System.Threading;

namespace Engine.Core.Threading
{
    public class MainThreadHandler : IThreadHandler
    {
        private static Thread _currentThread;

        public void StartThread(Action function)
        {
            if (_currentThread != null && _currentThread.IsAlive)
            {
                _currentThread.Abort();
            }

            var start = new ThreadStart(function);
            _currentThread = new Thread(start);
            _currentThread.Start();
        }

        public Thread GetCurrentThread()
        {
            return _currentThread;
        }

        public void StopThread()
        {
            throw new NotImplementedException();
        }
    }
}