using System.Drawing;
using API.Models.Request;
using Engine.BusinessLogic.DrawLogic;
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
            Drawer.Draw(BuildDTO(request));
        }

        private SinglePixelDTO BuildDTO(SinglePixelRequest request)
        {
            var dto = new SinglePixelDTO();
            dto.PixelLocation = new PixelLocationDTO {Row = request.Row, Col = request.Col};
            dto.Color = Color.FromArgb(100, request.Red, request.Green, request.Blue);
            return dto;
        }
    }
}