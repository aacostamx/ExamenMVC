using ExamenMVC.Models;
using System;
using System.Collections.Generic;

namespace ExamenMVC.ViewModels
{
    public class EmployeeVM
    {
        public Decimal EmployeeId { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }

        public List<Phone> Phones { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
