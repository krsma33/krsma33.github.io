using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rasadnik.Shared.Models;
using Rasadnik.Shared.Services;
using System.Security.Authentication;
using System.Threading.Tasks;

namespace Rasadnik.Server.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthService _loginService;

        public AuthenticationController(IAuthService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] UserDto login)
        {
            IActionResult response;

            try
            {
                var token = await _loginService.AuthenticateAsync(login);

                response = Ok(token);
            }
            catch (AuthenticationException)
            {
                response = Unauthorized();
            }

            return response;
        }
    }
}
