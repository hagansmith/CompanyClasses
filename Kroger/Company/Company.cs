using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kroger.Company
{
    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        List <string> employees = new List<string>() { };

        // Create a method that allows external code to add an employee
        public void AddEmployee()
        {
            employees.Add(new Employee() { });
        }

        // Create a method that allows external code to remove an employee
        public void RemoveEmployee()
        {
            employees.Remove(new Employee() { });
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
           
        */
        public Company(string companyName, DateTime createdDate)
        {
            Name = companyName;
            CreatedOn = createdDate;
        }

        public void ListEmployees()
        {
            foreach (string employee in employees)
            {
                Console.Write(employee);
            }
        }
    }
}
