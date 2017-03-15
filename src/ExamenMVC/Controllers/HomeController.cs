using ExamenMVC.Models;
using ExamenMVC.Repositories;
using ExamenMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ExamenMVC.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository employeeRepository;
        private IPhoneRepository phoneRepository;
        private ITaskRepository taskRepository;

        public HomeController(IEmployeeRepository employeeRepository, IPhoneRepository phoneRepository, ITaskRepository taskRepository)
        {
            this.employeeRepository = employeeRepository;
            this.phoneRepository = phoneRepository;
            this.taskRepository = taskRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AddEmployee(EmployeeVM emp)
        {
            var employee = employeeRepository.AddEmployee(new Employee { EmployeeName = emp.EmployeeName, EmployeeNumber = emp.EmployeeNumber });
            if (emp.Phones != null && emp.Phones.Any())
            {
                emp.Phones.Select(c => { c.EmployeeNumber = employee.EmployeeNumber; return c; }).ToList();
                phoneRepository.addPhones(emp.Phones);
            }

            if (emp.Tasks != null && emp.Tasks.Any())
            {
                emp.Tasks.Select(c => { c.EmployeeId = employee.EmployeeId; return c; }).ToList();
                taskRepository.addTasks(emp.Tasks);
            }

            return Json(employee);
        }

        public IActionResult Employees()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAllEmployees()
        {
            var employees = employeeRepository.GetAllEmployees().ToList();
            return Json(employees);
        }

        [HttpDelete]
        public JsonResult DeleteEmployee(decimal id)
        {
            var status = false;
            var employee = employeeRepository.FindEmployee(id);

            if(employee != null )
            {
                taskRepository.deleteTask(employee.EmployeeId);
                phoneRepository.deletePhone(employee.EmployeeNumber);
                employeeRepository.DeleteEmployee(employee.EmployeeId);
                status = true;
            }

            return Json(new { success = status });
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
