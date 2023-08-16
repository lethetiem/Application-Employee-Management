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

        public async Task<List<EmployeeDTO>> GetAllEmployees(){
            var employee = await _unitOfWork.Employees.GetAllEmployeeAsync();
            var employeeDTO = _mapper.Map<List<EmployeeDTO>>(employee);
            return employeeDTO;
        }

        public async Task AddNewEmployee(EmployeeDTO employeeDTO){
            var employeeEntity = _mapper.Map<Employee>(employeeDTO);
            await _unitOfWork.Employees.AddAsync(employeeEntity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> DeleteEmployee(Guid employeeDTO){
            var employeeEntity = await _unitOfWork.Employees.GetByIdAsync(employeeDTO);
            if(employeeEntity != null){
                await _unitOfWork.Employees.DeleteAsync(employeeEntity);
                await _unitOfWork.SaveChangesAsync();
                return true;
            }else{
                throw new Exception("Employee not found"); 
            }
        }

    }
}