using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise126
{
    class Employee : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("I quit!");
        }

        static void Main(string[] args)
        {
            IQuittable Employee = new Employee();
            Employee.Quit();

            Console.ReadLine();
        }
    }
}
