using AutoMapper;
using Employees_Application.Models;
using Employees_Application.Service.DTO;

namespace Employees_Application.Service.Mapper{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
        }
    }
}