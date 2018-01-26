using Microsoft.AspNetCore.Mvc;

namespace EdmxConv.Controllers
{
    public class HeartbeatController : BaseApiController
    {
        [HttpGet, Route("api/heartbeat")]
        public IActionResult Beat() => Ok();
    }
}