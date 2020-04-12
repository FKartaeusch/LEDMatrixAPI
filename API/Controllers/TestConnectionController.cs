using Engine.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestConnectionController : Controller
    {
        public TestConnectionController(ITestConnector testConnector)
        {
            testConnector.TestConnection();
        }

        [HttpGet]
        public void Testing()
        {
        }
    }
}