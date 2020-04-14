using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        [HttpPost]
        public string SendMessage(string message)
        {
            // Draw Message;
            return message + " will be drawn";
        }
    }
}