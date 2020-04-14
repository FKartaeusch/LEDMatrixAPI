using Engine.Core.Connection;
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
        public void TestConnection()
        {
            _testConnector.TestConnection();
        }
    }
}