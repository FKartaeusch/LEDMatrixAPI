namespace Engine.Core.Threading
{
    public interface IThreadHandler
    {
        public void StartThread();
        public void StopThread();
    }
}