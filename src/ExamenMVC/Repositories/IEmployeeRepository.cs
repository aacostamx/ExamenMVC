using ExamenMVC.Models;
using System;
using System.Collections.Generic;

namespace ExamenMVC.Repositories
{
    public interface IEmployeeRepository
    {
        Employee AddEmployee(Employee employee);
        IEnumerable<object> GetAllEmployees();
        Employee FindEmployee(decimal employeeId);
        void DeleteEmployee(Decimal id);
    }
}
