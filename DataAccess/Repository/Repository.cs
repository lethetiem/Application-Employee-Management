using Employees_Application.Data;
using Employees_Application.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Employees_Application.DataAccess.Repository{
    public class Repository<T> : IRepository<T> where T : class{
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db){
            _db = db;
            dbSet = _db.Set<T>();
        }

        public async Task<T> GetByIdAsync(Guid id){
            return await _db.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync(){
            return await _db.Set<T>().ToListAsync();
        }

        public async Task AddAsync(T entity){
            await _db.Set<T>().AddAsync(entity);
        }

        public async Task UpdateAsync(T entity){
            _db.Set<T>().Update(entity);
        }

        public async Task DeleteAsync(T entity){
            _db.Set<T>().Remove(entity);
        }
        public IEnumerable<T> GetAll(){
            return _db.Set<T>().ToList();
        }      
    }
}