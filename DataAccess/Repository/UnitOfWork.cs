using Employees_Application.Data;
using Employees_Application.DataAccess.Repository.IRepository;
using Employees_Application.Models;

namespace Employees_Application.DataAccess.Repository{
    public class UnitOfWork : IUnitOfWork{
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db){
            _db = db;
            Employees = new EmployeesRepository(_db);
        }

        public IEmployeesRepository Employees {get; private set;}

        public void Dispose(){
            _db.Dispose();
        }

        public void Save(){
            _db.SaveChanges();
        }
    }
}