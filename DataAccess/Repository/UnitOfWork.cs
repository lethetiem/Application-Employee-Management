using Employees_Application.Data;
using Employees_Application.DataAccess.Repository.IRepository;

namespace Employees_Application.DataAccess.Repository{
    public class UnitOfWork : IUnitOfWork{
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db){
            _db = db;
            Employees = new EmployeesRepository(_db);
            Users = new UsersRepository(_db);
        }

        public IEmployeesRepository Employees {get; private set;}
        public IUsersRepository Users {get; private set;}

        public async Task<int> SaveChangesAsync(){
            return await _db.SaveChangesAsync();
        }
    }
}