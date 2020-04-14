using Engine.BusinessLogic.ResetLogic;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ResetController : Controller
    {
        private readonly IResetLogic _resetLogic;

        public ResetController(IResetLogic resetLogic)
        {
            _resetLogic = resetLogic;
        }

        // GET
        public void Reset()
        {
            _resetLogic.Reset();
        }
    }
}