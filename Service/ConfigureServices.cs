using Employees_Application.DataAccess.Repository;
using Employees_Application.DataAccess.Repository.IRepository;

namespace Employees_Application.Service{
    public static class ConfigurationServices{
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddAutoMapperConfiguration();
        }
    }
}