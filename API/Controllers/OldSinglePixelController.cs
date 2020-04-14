using System.Drawing;
using API.Models.Request;
using Engine.BusinessLogic.DrawLogic;
using Engine.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OldSinglePixelController : Controller
    {
        private readonly IOldDrawSinglePixel Drawer;

        public OldSinglePixelController(IOldDrawSinglePixel drawer)
        {
            Drawer = drawer;
        }

        [HttpPost]
        public void SinglePixel([FromBody] OldSinglePixelRequest request)
        {
            var dto = new OldSinglePixelDTO();
            dto.PixelNumber = request.PixelNumber;
            dto.ClearImage = request.ClearImage;
            Drawer.Draw(dto);
        
        }
    }
}