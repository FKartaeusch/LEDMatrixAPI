using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : Controller
    {
        // GET
        [HttpGet]
        public void CheckHealth()
        {
        }
    }
}