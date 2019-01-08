using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise124
{
    abstract class Person
    {
        public String firstName;
        public String lastName;

        public void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

    }
}
