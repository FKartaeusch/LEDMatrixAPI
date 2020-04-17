using Engine.Core;
using Engine.Core.Threading;
using Engine.Models;
using Engine.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClockController : Controller
    {
        private readonly IStateHandler _stateHandler;
        private readonly IThreadHandler _threadHandler;

        public ClockController(IStateHandler stateHandler, IThreadHandler threadHandler)
        {
            _threadHandler = threadHandler;
            _stateHandler = stateHandler;
        }

        // GET
        [HttpGet]
        public void ShowClock()
        {
            _stateHandler.SetState(new StateDTO
            {
                Time = 10,
                StateCode = StateCode.ShowClock,
                NextState = StateCode.ShowClock
            });
            _threadHandler.StartThread();
        }
    }
}