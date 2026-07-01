using Microsoft.AspNetCore.Mvc;

namespace EmployeeService
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployeeDetails()
        {
            Employee employee = new Employee()
            {
                EmployeeId = Guid.NewGuid(),
                FirstName = "Test",
                LastName = "LastName",
                UserName = "TestLast",
                Email = "Test@gmail.com",
                Department = DepartmentType.HR,
                Salary = 25000
            };

            return Ok(employee);
        }
    }
}
