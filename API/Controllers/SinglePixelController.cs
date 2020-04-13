using API.Models.Request;
using Engine.BusinessLogic;
using Engine.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SinglePixelController : Controller
    {
        private readonly IDrawSinglePixel Drawer;

        public SinglePixelController(IDrawSinglePixel drawer)
        {
            Drawer = drawer;
        }

        [HttpPost]
        public void SinglePixel([FromBody] SinglePixelRequest request)
        {
            var dto = new SinglePixelDTO();
            dto.PixelNumber = request.PixelNumber;
            dto.ClearImage = request.ClearImage;
            Drawer.Draw(dto);
        }
    }
}