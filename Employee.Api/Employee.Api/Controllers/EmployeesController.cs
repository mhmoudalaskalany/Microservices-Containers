using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        [HttpGet("Get")]
        public Employee GetAsync()
        {
            return new()
            {
                Name = "Mahmoud Ragab",
                Position = "Full Stack Software Developer"
            };
        }

        [HttpGet("GetAll")]
        public IEnumerable<Employee> GetAllAsync()
        {
            return Enumerable.Range(1, 5).Select( _=> new Employee()
                {
                    Name = "Mahmoud Ragab",
                    Position = "Full Stack Software Developer"
                })
                .ToArray();
        }
    }
}