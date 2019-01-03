using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Exercise4
    {
        public int Sum(int i1, int i2 = 0)
        {
            return i1 + i2;
        }
    }

    class Exercise4Test
    {
        static void Main(string[] args)
        {
            Exercise4 ex = new Exercise4();

            Console.WriteLine("Input the first number: ");
            String s1 = Console.ReadLine();
            int n1 = Convert.ToInt32(s1);

            Console.WriteLine("Input the second number (OPTIONAL): ");
            String s2 = Console.ReadLine();
            int n2;

            // String control
            if (s2 == "")
            {
                n2 = 0;    
            }
            else n2 = Convert.ToInt32(s2);


            Console.WriteLine("Result: " + ex.Sum(n1,n2));
            // Console.WriteLine("Result: " + ex.Sum(n1));

            Console.ReadLine();
        }
    }
    
}
