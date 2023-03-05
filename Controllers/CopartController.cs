using Copart.Models.Output;
using Copart.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
            var returnList = new List<LotDetailsOutput>();
            returnList.Add(result);
            return View("LotDetails", returnList);
        }
    }
}
