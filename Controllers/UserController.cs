using Employees_Application.Models;
using Employees_Application.Service.Services;
using Employees_Application.Service.Services.IService;
using Microsoft.AspNetCore.Mvc;

namespace Employees_Application.Controllers{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : Controller{
        private readonly IAuthService _authService;
        public UserController(IAuthService authService){
            _authService = authService;
        }

       [HttpPost("login")]
       public async Task<IActionResult> Login([FromBody] User user){
        var result = await _authService.LoginAsync(user);
        if(result.SuccessV){
            return Ok(new {token = result.Token});
        }
        else{
            return BadRequest(result.Errors);
        }
       }

    }
}