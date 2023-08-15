using AutoMapper;
using Employees_Application.Service.Mapper;

namespace Employees_Application.Service{
    public static class AutoMapperExtensions{
        public static IServiceCollection AddAutoMapperConfiguration(this IServiceCollection services){
            var mappingConfig = new MapperConfiguration(mc =>{
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}