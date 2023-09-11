using Employees_Application.Service.DTO;

namespace Employees_Application.Service.Services.IService
{
    public interface IAuthService
    {
        Task<UserDTO> AuthenticationAsync(UserDTO userDTO);
        Task RegisterAsync(UserDTO userDTO);
    }
}