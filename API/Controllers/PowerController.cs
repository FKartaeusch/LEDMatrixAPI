using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PowerController : ControllerBase
    {
        [HttpGet]
        public string Power(bool powerOn)
        {
            if (powerOn) return "Gerät eingeschaltet";

            return "Gerät ausgeschaltet";
        }
    }
}