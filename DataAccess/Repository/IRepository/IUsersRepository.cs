using Employees_Application.Models;

namespace Employees_Application.DataAccess.Repository.IRepository{
    public interface IUsersRepository : IRepository<User>{
        Task<User> AuthenticationAsync(string username);
        Task AddUserAsync(User user);

        Task<bool> CheckUserNameExistAsync(string username);
        Task<bool> CheckEmailExistAsync(string email);
    }
}