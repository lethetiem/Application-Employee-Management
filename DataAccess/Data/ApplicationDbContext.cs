using Employees_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Employees_Application.Data{
    public class ApplicationDbContext: DbContext{
        public ApplicationDbContext(DbContextOptions options) : base(options){

        }

        public DbSet<Employee> Employees { get; set;}
        public DbSet<User> Users { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<User>().ToTable("users");
        }


    }
}