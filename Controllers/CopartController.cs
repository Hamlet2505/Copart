using Copart.Services;
using Microsoft.AspNetCore.Mvc;

namespace Copart.Controllers
{
    public class CopartController : Controller
    {
        private readonly ICopartDataService copartDataService;
        public CopartController(ICopartDataService copartDataService)
        {
            this.copartDataService = copartDataService;
        }

        [HttpGet]
        public IActionResult Home()
        {
            return View("LotDetails");
        }

        [HttpGet]
        public IActionResult GetLotDetails(string lotNumber)
        {
            var result = copartDataService.GetLotDetails(lotNumber);
            return Ok(result); 
        }
    }
}
