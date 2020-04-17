using Engine.Core;
using Engine.Models;
using Engine.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [
        ApiController]
    [Route("[controller]")]
    public class ClockController : Controller
    {
        private readonly IStateHandler _stateHandler;

        public ClockController(IStateHandler stateHandler)
        {
            _stateHandler = stateHandler;
        }

        // GET
        [HttpGet]
        public void ShowClock()
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