using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectionOperators
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int AnnualSalary { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee
                {
                    EmployeeID = 1,
                    FirstName = "Pratiksha",
                    LastName = "Deshmukh",
                    Gender = "Female",
                    AnnualSalary = 12000
                },
                 new Employee
                {
                    EmployeeID = 2,
                    FirstName = "Aarti",
                    LastName = "Deshmukh",
                    Gender = "Female",
                    AnnualSalary = 19000
                },
                  new Employee
                {
                    EmployeeID = 3,
                    FirstName = "sonu",
                    LastName = "Deshmukh",
                    Gender = "male",
                    AnnualSalary = 12000
                },
                   new Employee
                {
                    EmployeeID = 4,
                    FirstName = "shital",
                    LastName = "patil",
                    Gender = "Female",
                    AnnualSalary = 3000000
                },

            };
            return listEmployees;
        }
    }
}