using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
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