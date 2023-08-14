using Employees_Application.Data;
using Employees_Application.DataAccess.Repository.IRepository;
using Employees_Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Employees_Application.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : Controller {
        private readonly IUnitOfWork _unitOfWork;
        [HttpGet]
        public IActionResult GetAllEmployees() {
            var allObj = _unitOfWork.Employees.GetAll();
            // return Ok(allObj);
            return Json(new {data = allObj});
        }

        [HttpPost]
        public IActionResult AddEmployees([FromBody] Employee employeeRequest){
            employeeRequest.Id = Guid.NewGuid();

            _unitOfWork.Employees.Add(employeeRequest);
            _unitOfWork.Save();
            return Ok(employeeRequest);
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