namespace Employees_Application.DataAccess.Repository.IRepository{
    public interface IUnitOfWork{
        IEmployeesRepository Employees {get;}
        void Save();
    }
}