using System;
using System.Threading.Tasks;
using Hovedoppgave_2.Server.Models;
using Hovedoppgave_2.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hovedoppgave_2.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserService _userService;

        public AuthController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register(Hovedoppgave_2.Server.Models.RegisterRequest request) // Endret for å spesifikk bruke registerrequest i Models
        {
            try
            {
                var response = await _userService.Register(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(LoginRequest request)
        {
            try
            {
                var response = await _userService.Login(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}