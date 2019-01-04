using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Exercise2
    {
        public void Method(int n1, int n2)
        {
            int sum = n1 + n1;
            Console.WriteLine(n2);
        }
    }

    class Exercise2Test
    {
        static void Main(string[] args)
        {
            Exercise2 ex = new Exercise2();

            ex.Method(2, 3);

            int number1 = 2;
            int number2 = 3;
            ex.Method(number1, number2);

            Console.ReadLine();
        }
    }

}
