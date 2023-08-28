using Employees_Application.Models;

namespace Employees_Application.Service.Services.IService{
    public interface IAuthService{
        Task<AuthResult> LoginAsync(User user);
    }
}