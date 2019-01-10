using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise140
{
    class Employee
    {
        public int id;
        public string firstName;
        public string lastName;

        public Employee(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void printEmployee()
        {
            Console.WriteLine(id + ", " + firstName + " " + lastName);
        }
    }
}