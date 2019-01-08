using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_120
{
    public class Person
    {
        public String FirstName;
        public String LastName;

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

    }
}

