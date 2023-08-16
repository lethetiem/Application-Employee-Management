using AutoMapper;

namespace Employees_Application.Service.Mapper
{
    public static class MapperConfig
    {
        public static MapperConfiguration ConfiguationMappings()
        {
            return new MapperConfiguration(config => 
            {
                config.AddProfile<MappingProfile>();
            });
        }
    }
}