using Azure.Core;
using Employees_Application.Service.DTO;
using Employees_Application.Service.Services.IService;
using Microsoft.AspNetCore.Mvc;

namespace Employees_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : Controller
    {
        private readonly IAuthService _authService;
        public UserController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserDTO userDTO)
        {
            try
            {
                var user = await _authService.AuthenticationAsync(userDTO);
                return Ok(new {
                    Message = "Login Success!"
                 });

            }
            catch (Exception ex)
            {
                return BadRequest($"Error login user: {ex.Message}");
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserDTO userDTO)
        {
            try
            {
                await _authService.RegisterAsync(userDTO);
                return Ok(new
                {
                    Message = "User is registered"
                });

            }
            catch (Exception ex)
            {
                return BadRequest($"Error adding new user {ex.Message}");
            }
        }

    }
}