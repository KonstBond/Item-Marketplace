using Microsoft.AspNetCore.Mvc;

namespace Item_Marketplace.Api.Controllers.v1._0
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class AuctionController : Controller
    {
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetItems() 
        {
            return Json(false);
        }
    }
}
