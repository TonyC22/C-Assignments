using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Exercise3
    {
    
        public int SumItself(int i)
        {
            return i + i;
        }

        public decimal SumItself(decimal f)
        {
            return f * f;
        }

        public int SumItself(String s)
        {
            int sToInt = Convert.ToInt32(s);
            return sToInt - 1;
        }

    }

    class Exercise3Test
    {
        static void Main(string[] args)
        {
            Exercise3 ex1 = new Exercise3();
            Console.WriteLine(ex1.SumItself(12));

            Exercise3 ex2 = new Exercise3();
            Console.WriteLine(ex2.SumItself(3.4m));

            Exercise3 ex3 = new Exercise3();
            Console.WriteLine(ex3.SumItself("3"));

            Console.ReadLine();
        }
    }
    
}
