using API.Models.Request;
using Engine.BusinessLogic;
using Engine.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class SinglePixelController : Controller
    {
        private readonly IDrawSinglePixel Drawer;

        public SinglePixelController(IDrawSinglePixel drawer)
        {
            Drawer = drawer;
        }

        [HttpPost]
        public void Index(SinglePixelRequest request)
        {
            var dto = new SinglePixelDTO();
            dto.pixelNumber = request.pixelNumber;
            dto.AnimationStyle = request.AnimationStyle;
            dto.ClearImage = request.ClearImage;
            Drawer.Draw(dto);
        }
    }
}