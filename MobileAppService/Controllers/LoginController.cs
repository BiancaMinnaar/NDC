using System;
using Microsoft.AspNetCore.Mvc;

namespace NDC.MobileAppService.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login(string userName, string password)
        {
            return Ok();
        }
    }
}
