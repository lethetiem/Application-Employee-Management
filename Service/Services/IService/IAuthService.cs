using Employees_Application.Service.DTO;

namespace Employees_Application.Service.Services.IService
{
    public interface IAuthService
    {
        // Task<string> AuthenticationAsync(string username, string password);
        Task<string> AuthenticationAsync(UserDTO userDTO);
        Task RegisterAsync(UserDTO userDTO);
    }
}