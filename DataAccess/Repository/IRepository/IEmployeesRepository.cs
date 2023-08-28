using Employees_Application.Models;

namespace Employees_Application.DataAccess.Repository.IRepository{
    public interface IEmployeesRepository: IRepository<Employee>{
        Task<IEnumerable<Employee>> GetAllEmployeeAsync();
        Task CreateNewEmployee(Employee employee);
        Task<Employee> GetByIdAsync(int id);
        Task Remove(Employee employee);
        Task Update(Employee employee);
    }
}