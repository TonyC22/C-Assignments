using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_120
{
    public class Employee : Person
    {
        int Id;

        static void Main(string[] args)
        {
            Employee Employee = new Employee();
            Employee.FirstName = "Sample";
            Employee.LastName = "Student";

            Employee.SayName();

            Console.ReadLine();
        }
    }
}
