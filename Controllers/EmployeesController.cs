using Employees_Application.Service.DTO;
using Employees_Application.Service.Services.IService;
using Microsoft.AspNetCore.Mvc;

namespace Employees_Application.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : Controller {
        private readonly IEmployeeService _employeesService;
        public EmployeesController(IEmployeeService employeeService) {
            _employeesService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _employeesService.GetAllEmployees();
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewEmployee(EmployeeDTO employeeRequest){
            try{
                await _employeesService.AddNewEmployee(employeeRequest);
                return Ok("Employee added successfully.");
            }catch(Exception ex){
                return BadRequest($"Error adding employee: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(Guid id){
            try{
                await _employeesService.DeleteEmployee(id);
                return Ok("Employee deleted successfully");
            }catch(Exception ex){
                return BadRequest($"Error deleting employee: {ex.Message}");
            }
        }
    }
}