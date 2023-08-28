using Employees_Application.Models;

namespace Employees_Application.Service.Services.IService{
    public interface ITokenService {
        string GenerateToken(User user);
    }
}