using Engine.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestConnectionController : Controller
    {
        private readonly ITestConnector _testConnector;

        public TestConnectionController(ITestConnector testConnector)
        {
            _testConnector = testConnector;
        }

        [HttpGet]
        public bool Testing()
        {
            return _testConnector.TestConnection();
        }
    }
}