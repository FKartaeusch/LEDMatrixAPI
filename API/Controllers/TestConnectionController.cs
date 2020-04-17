using Engine.Core;
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

        public TestConnectionController(IStateHandler stateHandler)
        {
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
        }
    }
}