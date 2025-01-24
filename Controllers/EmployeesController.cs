using API111.Data;
using Microsoft.AspNetCore.Mvc;

namespace API111.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
       private readonly ApplicationDbContext _dbContext;
       
       public EmployeesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            var empolyees = _dbContext.Employees;
            //if (empolyees.Count == 0) NotFound();

            return Ok(empolyees);
        }
        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetEmployeeById(Guid id)
        {
            var empolyees = _dbContext.Employees.ToList();
            return Ok(empolyees);   
        }

        [HttpPost]
        public IActionResult AddEmployee()
        {
            //var empolyees = _dbContext.Employees.ToList();
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateEmployee()
        {
            //var empolyees = _dbContext.Employees.ToList();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteEmployee()
        {
            //var empolyees = _dbContext.Employees.ToList();
            return Ok();
        }

    }
}
