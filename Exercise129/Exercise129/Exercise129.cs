using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise129
{

    class Employee
    {
        int Id;

        public static bool operator ==(Employee Emp1, Employee Emp2)
        {
            if (Emp1.Id == Emp2.Id)
            {
                return true;
            }
            else return false;
        }

        public static bool operator !=(Employee Emp1, Employee Emp2)
        {
            if (Emp1.Id != Emp2.Id)
            {
                return true;
            }
            else return false;
        }

        static void Main(string[] args)
        {
            Employee Employee1 = new Employee();
            Employee Employee2 = new Employee();

            Employee1.Id = 2;
            Employee2.Id = 2;

            if (Employee1.Id == Employee2.Id)
            {
                Console.WriteLine("Equal");
            }
            else Console.WriteLine("Not equal");

            Console.ReadLine();
        }
    }
}
