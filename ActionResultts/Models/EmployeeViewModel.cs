using ActionResultts.Entities;
using System.Collections.Generic;

namespace ActionResultts.Models
{
    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<string> Cities { get; set; }
        public Employee Employee { get; internal set; }
    }
}
