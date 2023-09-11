using Employees_Application.Data;
using Employees_Application.DataAccess.Repository.IRepository;
using Employees_Application.Models;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;

namespace Employees_Application.DataAccess.Repository{
    public class UsersRepository : Repository<User>, IUsersRepository{
        private readonly ApplicationDbContext _db;

        public UsersRepository(ApplicationDbContext db) : base(db){
            _db = db;
        }
        public async Task<User> AuthenticationAsync(string username){
            return  await _db.Users.FirstOrDefaultAsync(x => x.UserName == username);
        }

        public async Task AddUserAsync(User user){
            await AddAsync(user);
        }

        public async Task<bool> CheckUserNameExistAsync(string username){
            return await _db.Users.AnyAsync(u => u.UserName == username);
        }

        public async Task<bool> CheckEmailExistAsync(string email){
            return await _db.Users.AnyAsync(u => u.Email == email);
        }
        


    }
}