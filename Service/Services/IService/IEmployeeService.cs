using Employees_Application.Service.DTO;

namespace Employees_Application.Service.Services.IService{
    public interface IEmployeeService{
        Task<List<EmployeeDTO>> GetAllEmployees();
        Task AddNewEmployee(EmployeeDTO employeeDTO);
        Task<EmployeeDTO> DeleteEmployee(Guid employeeDTO);
    }
}