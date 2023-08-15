using Employees_Application.Data;
using Employees_Application.DataAccess.Repository.IRepository;
using Employees_Application.Models;
using Employees_Application.Service.Services.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Employees_Application.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : Controller {
        private readonly IEmployeeService _employeesService;
        public EmployeesController(IEmployeeService employeeService) {
            _employeesService = employeeService;
        }

        [HttpGet]
        public IActionResult GetAllEmployees() {
            var allObj = _employeesService.GetAllEmployees();
            return Ok(allObj);
        }

        // private readonly ApplicationDbContext _applicationDbContext;
        // public EmployeesController(ApplicationDbContext applicationDbContext)
        // {
        //     _applicationDbContext = applicationDbContext;
        // }

        // [HttpGet]
        // public async Task<IActionResult> GetAllEmployees(){
        //     var employees = await _applicationDbContext.Employees.ToListAsync();
        //     return Ok(employees);
        // }

        // [HttpPost]
        // public async Task<IActionResult> AddEmployee([FromBody] Employee employeeRequest){
        //     employeeRequest.Id = Guid.NewGuid();

        //     await _applicationDbContext.Employees.AddAsync(employeeRequest);
        //     await _applicationDbContext.SaveChangesAsync();

        //     return Ok(employeeRequest);
        // }

    }
}