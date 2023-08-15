using System.Linq.Expressions;

namespace Employees_Application.DataAccess.Repository.IRepository{
    public interface IRepository<T> where T : class{
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}