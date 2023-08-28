using Employees_Application.Models;

namespace Employees_Application.DataAccess.Repository.IRepository{
    public interface IUsersRepository : IRepository<User>{
        Task<User> GetUserByUsernameAsync(string username);
        Task AddUserAsync(User user);
    }
}