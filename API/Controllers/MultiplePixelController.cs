using System.Collections.Generic;
using System.Drawing;
using API.Models.Request;
using Engine.BusinessLogic.DrawLogic;
using Engine.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MultiplePixelController : Controller
    {
        private readonly IDrawSinglePixel Drawer;

        public MultiplePixelController(IDrawSinglePixel drawer)
        {
            Drawer = drawer;
        }

        [HttpPost]
        public void MultiplePixel([FromBody] List<SinglePixelRequest> request)
        {
            foreach (var singleRequest in request)
            {
                Drawer.Draw(BuildDTO(singleRequest));

            }

        }

        private SinglePixelDTO BuildDTO(SinglePixelRequest request)
        {
            var dto = new SinglePixelDTO();
            dto.PixelLocation = new PixelLocationDTO {Row = request.Row, Col = request.Col};
            dto.Color = Color.FromArgb(0xff, request.Red, request.Green, request.Blue);
            return dto;
        }
    }
}