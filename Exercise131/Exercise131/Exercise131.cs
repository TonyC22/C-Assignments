using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise131
{
    public class EmpTest
    {
        static void Main(string[] args)
        {
            Employee<String> Employee1 = new Employee<String>();
            Employee1.things.Add("House");
            Employee1.things.Add("Car");
            Employee1.things.Add("Dog");

            Employee<int> Employee2 = new Employee<int>();
            Employee2.things.Add(1);
            Employee2.things.Add(2);
            Employee2.things.Add(3);

            foreach (var Employee in Employee1.things)
                Console.WriteLine(Employee);

            foreach (var Employee in Employee2.things)
                Console.WriteLine(Employee);

            Console.ReadLine();
        }
    }
}
