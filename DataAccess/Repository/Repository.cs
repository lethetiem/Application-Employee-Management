using System.Linq.Expressions;
using AutoMapper;
using Employees_Application.Data;
using Employees_Application.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Employees_Application.DataAccess.Repository{
    public class Repository<T> : IRepository<T> where T : class{
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db){
            _db = db;
            this.dbSet = _db.Set<T>();
        }

        public void Add(T entity){
            dbSet.Add(entity);
        }

        public T Get(int id){
            return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll(){
            return _db.Set<T>().ToList();
        }      
    }
}