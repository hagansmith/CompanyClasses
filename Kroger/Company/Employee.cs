using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kroger.Employee
{
    public class Employee
    {
        protected string _employeeName;
        protected string _employeeJobTitle;
        protected DateTime _employeeStartDate;

        public string EmployeeName { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }

    }
}
