using Employees_Application.Service.DTO;
using Employees_Application.Service.Services.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Employees_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService _employeesService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeesService = employeeService;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _employeesService.GetAllEmployees();
            return Ok(employees);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddNewEmployee(EmployeeDTO employeeRequest)
        {
            try
            {
                await _employeesService.AddNewEmployee(employeeRequest);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Error adding employee: {ex.Message}");
            }
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(Guid id)
        {
            try
            {
                await _employeesService.DeleteEmployee(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Error deleting employee: {ex.Message}");
            }
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployees(Guid id, [FromBody] EmployeeDTO employeeDTO)
        {
            if (id != employeeDTO.Id.Value)
            {
                throw new ArgumentException("Employee ID is missing");
            }

            try
            {
                await _employeesService.GetEmployee(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Error get id employee: {ex.Message}");
            }
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(Guid id, [FromBody] EmployeeDTO employeeDTO)
        {
            if (id != employeeDTO.Id.Value)
            {
                throw new ArgumentException("Employee ID is missing");
            }

            try
            {
                var updateEmployee = await _employeesService.UpdateEmployee(employeeDTO);
                return Ok(updateEmployee);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error updating employee: {ex.Message}");
            }
        }
    }
}