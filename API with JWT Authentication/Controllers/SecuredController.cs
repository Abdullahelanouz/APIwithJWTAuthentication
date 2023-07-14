using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_with_JWT_Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SecuredController : ControllerBase
    {
        [HttpGet]

        public IActionResult GetData()
        {
            return Ok("Hello from secured controller");
        }
    }
}
