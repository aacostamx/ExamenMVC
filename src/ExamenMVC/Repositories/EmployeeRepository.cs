using ExamenMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamenMVC.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private _Context context;
        public DbSet<Employee> employeesEntity;

        public EmployeeRepository(_Context context)
        {
            this.context = context;
            employeesEntity = context.Set<Employee>();
        }

        public Employee AddEmployee(Employee employee)
        {
            var dbEmployee = new Employee();

            var exits = employeesEntity.Where(c => c.EmployeeNumber == employee.EmployeeNumber).FirstOrDefault();

            if (exits == null)
            {
                context.Entry(employee).State = EntityState.Added;
                context.SaveChanges();
                dbEmployee = employee;
            }
            else
            {
                dbEmployee = exits;
            }

            return dbEmployee;
        }

        public void DeleteEmployee(Decimal id)
        {
            var delete = employeesEntity.Where(c => c.EmployeeId == id).FirstOrDefault();

            if (delete != null)
            {
                employeesEntity.Remove(delete);
                context.SaveChanges();
            }
        }

        public IEnumerable<object> GetAllEmployees()
        {
            var employees = employeesEntity.AsEnumerable();
            return employees;
        }

        public Employee FindEmployee(decimal employeeId)
        {
            var dbEmployee = new Employee();

            dbEmployee = employeesEntity.Where(c => c.EmployeeId == employeeId).FirstOrDefault();

            return dbEmployee;
        }
    }
}
