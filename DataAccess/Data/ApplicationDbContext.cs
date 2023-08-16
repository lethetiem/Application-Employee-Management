using Employees_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Employees_Application.Data{
    public class ApplicationDbContext: DbContext{
        public ApplicationDbContext(DbContextOptions options) : base(options){

        }

        public DbSet<Employee> Employees { get; set;}
        
        
    }
}