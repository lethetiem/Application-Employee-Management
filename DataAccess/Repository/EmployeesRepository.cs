using Employees_Application.Data;
using Employees_Application.DataAccess.Repository.IRepository;
using Employees_Application.Models;

namespace Employees_Application.DataAccess.Repository{
    public class EmployeesRepository : Repository<Employee>, IEmployeesRepository{
        private readonly ApplicationDbContext _db;

        public EmployeesRepository(ApplicationDbContext db) : base(db){
            _db = db;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeeAsync(){
            return await GetAllAsync();
        }

        public async Task CreateNewEmployee(Employee employee){
            await AddAsync(employee);
        }

        public async Task<Employee> GetByIdAsync(int id){
            return await _db.Employees.FindAsync(id);
        }

        public async Task Remove(Employee employee){
            await DeleteAsync(employee);
        }


    }
}