namespace Employees_Application.DataAccess.Repository.IRepository{
    public interface IUnitOfWork : IDisposable{
        IEmployeesRepository Employees {get;}

        void Save();
    }
}