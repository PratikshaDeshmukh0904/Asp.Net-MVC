using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectionOperators
{
    internal class Prediction
    {
        static void Main(string[] args)
        {
           IEnumerable<int> result = Employee.GetAllEmployees().Select(emp => emp.EmployeeID);
            foreach(int id in result)
            {
                Console.WriteLine(id);
               
            }


            var result1 = Employee.GetAllEmployees().Select(emp => new { FirstName = emp.FirstName, Gender = emp.Gender });
            foreach (var v in result1)
            {
                Console.WriteLine(v.FirstName+ " - " +v.Gender);
               

            }

            var result2 = Employee.GetAllEmployees().Select(emp => new { Fullname = emp.FirstName+ " "+emp.LastName, Gender = emp.Gender ,MonthlySalary = emp.AnnualSalary/12});
            foreach (var v in result2)
            {
                Console.WriteLine(v.Fullname + " - " + v.Gender+ " -"+v.MonthlySalary);
                

            }

            var result3 = Employee.GetAllEmployees().Where(emp =>emp.AnnualSalary > 50000).Select(
                emp => new 
                {   
                    Fullname = emp.FirstName + " " + emp.LastName,
                    Gender = emp.Gender,
                    AnnualSalary = emp.AnnualSalary,
                    Bonus = emp.AnnualSalary * .1
                }
                );
            foreach (var v in result3)
            {
                Console.WriteLine(v.Fullname + " - " + v.Gender + " -" + v.AnnualSalary + "-"+v.Bonus);
                Console.ReadLine();

            }
        }
        
    }
}
