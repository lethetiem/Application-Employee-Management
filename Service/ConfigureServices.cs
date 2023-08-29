using Employees_Application.DataAccess.Repository;
using Employees_Application.DataAccess.Repository.IRepository;
using Employees_Application.Service.Services;
using Employees_Application.Service.Services.IService;

namespace Employees_Application.Service{
    public static class ConfigurationServices{
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            // services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAuthService, AuthService>();
            // services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<ITokenService, TokenService>();
        }
    }
}