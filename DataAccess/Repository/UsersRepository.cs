using Employees_Application.Data;
using Employees_Application.DataAccess.Repository.IRepository;
using Employees_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Employees_Application.DataAccess.Repository{
    public class UsersRepository : Repository<User>, IUsersRepository{
        private readonly ApplicationDbContext _db;

        public UsersRepository(ApplicationDbContext db) : base(db){
            _db = db;
        }

        public async Task<User> GetUserByUsernameAsync(string username){
            return await _db.Users.SingleOrDefaultAsync(x => x.UserName == username);
        }

        public async Task AddUserAsync(User user){
            await _db.Users.AddAsync(user);
            await _db.SaveChangesAsync();
        }

    }
}