using Employees_Application.Data;
using Employees_Application.DataAccess.Repository.IRepository;
using Employees_Application.Models;

namespace Employees_Application.DataAccess.Repository{
    public class EmployeesRepository : Repository<Employee>, IEmployeesRepository{
        private readonly ApplicationDbContext _db;

        public EmployeesRepository(ApplicationDbContext db) : base(db){
            _db = db;
        }

        public IEnumerable<Employee> GetAllEmployees(){
            return _db.Employees.ToList();
        }
    }
}