namespace Employees_Application.DataAccess.Repository.IRepository{
    public interface IUnitOfWork{
        IEmployeesRepository Employees {get;}
        IUsersRepository Users {get;}
        Task<int> SaveChangesAsync();
    }
}