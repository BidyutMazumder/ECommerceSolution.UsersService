using ECommerce.Core.Contracts.Services;
using ECommerce.Core.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Core.DTO;

namespace ECommerce.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }
        [Route("register")]
        [HttpGet]
        public async Task<IActionResult> Register(RegisterRequest regiserRequest)
        {
            throw new NotImplementedException();
        }
        Login()
        {

        }


    }
}
