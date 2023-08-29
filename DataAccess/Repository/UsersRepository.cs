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

        public async Task<User> GetUserByUsernameAsync(User user){
            // return await _db.Users.SingleOrDefaultAsync(x => x.UserName == username);
            return await _db.Users.FirstOrDefaultAsync(x => x.UserName == user.UserName && x.Password == user.Password);
        }

        public async Task AddUserAsync(User user){
            await AddAsync(user);
        }

    }
}