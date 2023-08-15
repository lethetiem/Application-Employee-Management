using Employees_Application.Models;

namespace Employees_Application.DataAccess.Repository.IRepository{
    public interface IEmployeesRepository: IRepository<Employee>{

        IEnumerable<Employee> GetAllEmployees();
    }
}