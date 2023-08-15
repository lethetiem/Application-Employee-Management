using Employees_Application.Service.DTO;

namespace Employees_Application.Service.Services.IService{
    public interface IEmployeeService{
        IEnumerable<EmployeeDTO> GetAllEmployees();
    }
}