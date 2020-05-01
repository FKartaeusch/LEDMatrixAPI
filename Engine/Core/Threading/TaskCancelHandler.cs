using System.Threading;

namespace Engine.Core.Threading
{
    public class TaskCancelHandler : ICancelHandler
    {
        private static CancellationTokenSource _source;

        public void Cancel()
        {
            var cancelSource = GetCancellationToken();
            cancelSource.Cancel();
        }

        private CancellationTokenSource GetCancellationToken()
        {
            if (_source == null)
            {
                _source = new CancellationTokenSource();
            }

            return _source;
        }
    }
}