using Employees_Application.Service.DTO;

namespace Employees_Application.Service.Services.IService{
    public interface IJwtService {
        public string CreateJwt(UserDTO userDTO);
    }
}