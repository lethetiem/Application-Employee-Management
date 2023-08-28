using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Employees_Application.Models;
using Employees_Application.Service.Services.IService;
using Microsoft.IdentityModel.Tokens;

namespace Employees_Application.Service.Services{
    public class TokenService : ITokenService{
        private readonly IConfiguration _configuration;

        public string GenerateToken(User user){
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Secret"]);

            var tokenDescriptor = new SecurityTokenDescriptor{
                Subject = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.UserName),
                }),

                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}