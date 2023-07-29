using Microsoft.AspNetCore.Mvc;

namespace Item_Marketplace.Api.Controllers.v1._0
{
    [ApiController]
    [ApiVersion("0.1")]
    [Route("api/v{version:apiVersion}")]
    public class ApiController : Controller
    {
        [HttpGet]
        [Route("auctions")]
        public IActionResult Auctions() 
        {
            return Json(false);
        }
    }
}
