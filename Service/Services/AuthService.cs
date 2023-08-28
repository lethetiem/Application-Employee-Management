using Employees_Application.DataAccess.Repository.IRepository;
using Employees_Application.Models;
using Employees_Application.Service.Services.IService;

namespace Employees_Application.Service.Services{
    public class AuthService : IAuthService{
        private readonly IUsersRepository _usersRepository;
        private readonly ITokenService _tokenService;

        public AuthService(IUsersRepository usersRepository, ITokenService tokenService){
            _usersRepository = usersRepository;
            _tokenService = tokenService;
        }

        private bool VerifyPasswordHash(string password, string storedPassword){
            return BCrypt.Net.BCrypt.Verify(password, storedPassword);
        }

        public async Task<AuthResult> LoginAsync(User user){
            var userLogin = await _usersRepository.GetUserByUsernameAsync(user.UserName);
            if(userLogin == null || !VerifyPasswordHash(user.Password, userLogin.Password)){
                return AuthResult.Failure("Invalid username or password");
            }
            var token = _tokenService.GenerateToken(userLogin);
            return AuthResult.Success(token);
        }
    }
}