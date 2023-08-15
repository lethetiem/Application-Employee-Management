using AutoMapper;
using Employees_Application.DataAccess.Repository.IRepository;
using Employees_Application.Models;
using Employees_Application.Service.DTO;
using Employees_Application.Service.Services.IService;

namespace Employees_Application.Service.Services{
    public class EmployeeService : IEmployeeService{
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IMapper mapper, IUnitOfWork unitOfWork){
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<EmployeeDTO> GetAllEmployees(){
            var employee = _unitOfWork.Employees.GetAllEmployees();
            var employeeDTO = _mapper.Map<IEnumerable<EmployeeDTO>>(employee);
            return employeeDTO;
        }
    }
}