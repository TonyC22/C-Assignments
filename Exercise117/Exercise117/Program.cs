using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise117
{
    class Exercise117
    {
        public void Divide(int i)
        {
            Console.WriteLine(i / 2);
        }

        public void Divide(decimal d)
        {
            Console.WriteLine(d / 2);
        }
    }

    static class Exercise117Test
    {
        static void Main(string[] args)
        {
            Exercise117 ex = new Exercise117();

            Console.WriteLine("Input a number: ");
            String s = Console.ReadLine();
            int n = Convert.ToInt32(s);

            ex.Divide(n);

            Console.ReadLine();
        }
    }

}
