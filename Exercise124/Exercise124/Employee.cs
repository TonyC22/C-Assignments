using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise124
{
    class Employee : Person
    {
        public new void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        static void Main(string[] args)
        {
            Employee Employee = new Employee();
            Employee.firstName = "Sample";
            Employee.lastName = "Student";

            Employee.SayName();

            Console.ReadLine();
        }
    }
}
