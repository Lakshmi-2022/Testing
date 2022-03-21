using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.IServices;
using WebAPICore.Models;

namespace WebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        public EmployeeController(IEmployeeService employee)
        {
            employeeService = employee;
        }
       
        [HttpGet]
      [Route("[action]")]
      [Route("api/Employee/GetEmployee")]
        public IEnumerable<Employee> GetEmployee()
        {
            return employeeService.GetEmployee();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Employee/CreateEmployee")]
        public Employee AddEmployee(Employee emp)
        {
            return employeeService.AddEmployee(emp);
        }

        [HttpPut]
        public Employee EditEmployee(Employee emp)
        {
            return employeeService.UpdateEmployee(emp);
        }

        [HttpDelete]
        public Employee DeleteEmployee(int id)
        {
            return employeeService.DeleteEmployee(id);
        }
    }
}
