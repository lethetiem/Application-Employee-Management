using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Employees_Application.Service.DTO;
using Employees_Application.Service.Services.IService;
using Microsoft.IdentityModel.Tokens;

namespace Employees_Application.Service.Services
{
    public class JwtService : IJwtService
    {
        // private readonly IConfiguration _configuration;

        public string CreateJwt(UserDTO userDTO)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("veryverysecret.....");
            var identity = new ClaimsIdentity(new Claim[]{
                new Claim(ClaimTypes.Role, userDTO.Role),
                new Claim(ClaimTypes.Name, $"{userDTO.FirstName} {userDTO.LastName}")
            });

            var credentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = identity,
                Expires = DateTime.Now.AddHours(5),
                SigningCredentials = credentials
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            return jwtTokenHandler.WriteToken(token);

            // var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Secret"]);

            // var tokenDescriptor = new SecurityTokenDescriptor{
            //     Subject = new ClaimsIdentity(new[] {
            //         new Claim(ClaimTypes.NameIdentifier, userDTO.Id.ToString()),
            //         new Claim(ClaimTypes.Name, userDTO.UserName),
            //     }),

            //     Expires = DateTime.UtcNow.AddDays(7),
            //     SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            // };

            // var token = JwtTokenHandler.CreateToken(tokenDescriptor);
            // return JwtTokenHandler.WriteToken(token);
        }
    }
}