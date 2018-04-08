using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVVM.Models
{
    public class Employee
    {
        public int empId { get; set; }
        public string empName { get; set; }
        public int empSalary { get; set; }
    }

    public class EmployeeViewModel
    {
        public string empName { get; set; }
        public int empSalary { get; set; }
        public int empSalaryColor { get; set; }
    }
}