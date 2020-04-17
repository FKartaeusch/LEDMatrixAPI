using System;
using System.Threading;

namespace Engine.Core.Threading
{
    public interface IThreadHandler
    {
        public void StartThread(Action function);
        public Thread GetCurrentThread();
        public void StopThread();
    }
}