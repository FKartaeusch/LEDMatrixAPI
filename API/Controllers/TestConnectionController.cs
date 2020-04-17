using Engine.Core;
using Engine.Core.Threading;
using Engine.Models;
using Engine.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestConnectionController : Controller
    {
        private readonly IStateHandler _stateHandler;
        private readonly IThreadHandler _threadHandler;

        public TestConnectionController(IStateHandler stateHandler, IThreadHandler threadHandler)
        {
            _threadHandler = threadHandler;
            _stateHandler = stateHandler;
        }

        [HttpGet]
        public void TestConnection()
        {
            _stateHandler.SetState(new StateDTO
            {
                Time = 10,
                StateCode = StateCode.TestConnection,
                NextState = StateCode.ShowClock
            });

            _threadHandler.StartThread();
        }
    }
}