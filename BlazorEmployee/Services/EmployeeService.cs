using BlazorEmployee.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEmployee.Services
{
    public class EmployeeService
    {
        private readonly AppDbContext _context;

        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }


        //for CRUD operation

        //GEt all Employee
        public List<Employee> GetAllEmployee() => _context.Employees.ToList();

        //Insert Employee
        public string Create(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
            return "Save Successfully";
        }

        //Get Employye by ID:
        public Employee GetEmployeeById(int id) => _context.Employees.FirstOrDefault(e => e.Id == id);

        //Update Employee
        public string UpdateEmpoyee(Employee employee)
        {
            _context.Update(employee);
            _context.SaveChanges();
            return "Update Successfully";
        }

        //Delete Employee:
        public string deleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return "Delete Successfully";
        }
       

    }
}
