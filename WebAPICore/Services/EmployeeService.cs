using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.IServices;
using WebAPICore.Models;

namespace WebAPICore.Services
{
    public class EmployeeService : IEmployeeService
    {
        APICoreDBContext dbContext;
        public EmployeeService(APICoreDBContext db)
        {
            dbContext = db;
        }

        public Employee AddEmployee(Employee employee)
        {
            dbContext.Employee.Add(employee);
            dbContext.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            var emp = dbContext.Employee.Find(id);
            dbContext.Employee.Remove(emp);
            dbContext.SaveChanges();
            return emp;
        }

        public IEnumerable<Employee> GetEmployee()
        {
            return dbContext.Employee.ToList(); 
        }

        public Employee UpdateEmployee(Employee employee)
        {
            dbContext.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return employee;
        }
    }
}
