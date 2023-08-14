using Employees_Application.Data;
using Employees_Application.DataAccess.Repository.IRepository;
using Employees_Application.Models;

namespace Employees_Application.DataAccess.Repository{
    class EmployeesRepository : Repository<Employee>, IEmployeesRepository{
        private readonly ApplicationDbContext _db;

        public EmployeesRepository(ApplicationDbContext db) : base(db){
            _db = db;
        }

        public void Update(Employee employee){
            var objFromDb = _db.Employees.FirstOrDefault(s => s.Id == employee.Id);
            if(objFromDb != null){
                objFromDb.FullName = employee.FullName;
                objFromDb.Email = employee.Email;
                objFromDb.PhoneNumber = employee.PhoneNumber;
                objFromDb.Address = employee.Address;
                objFromDb.CompanyCategory = employee.CompanyCategory;
                objFromDb.Gender = employee.Gender;
            }
        }
    }
}