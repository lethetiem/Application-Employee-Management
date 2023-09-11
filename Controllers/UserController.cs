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
        private readonly IJwtService _jwtService;

        public UserController(IAuthService authService, IJwtService jwtService)
        {
            _authService = authService;
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserDTO userDTO)
        {
            try
            {
                if (userDTO == null)
                {
                    return BadRequest();
                }
                var user = await _authService.AuthenticationAsync(userDTO);
                if (user == null)
                {
                    return NotFound("Not Found User");
                }
                user.Token = _jwtService.CreateJwt(user);
                return Ok(new
                {
                    user.Token,
                    Message = "Login Successes!",
                    redirectUrl = "/Home",
                });
            }
            catch (ApplicationException ex)
            {
                ModelState.AddModelError("error", ex.Message);
                return BadRequest(ModelState);
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserDTO userDTO)
        {
            try
            {
                if (userDTO == null)
                {
                    return BadRequest();
                }
                await _authService.RegisterAsync(userDTO);
                return Ok(new
                {
                    Message = "User Registered!"
                });

            }
            catch (ApplicationException ex)
            {
                ModelState.AddModelError("error", ex.Message);
                return BadRequest(ModelState);
            }
        }

    }
}