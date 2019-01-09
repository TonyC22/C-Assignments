using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise137
{
    class Exercise137
    {
        static void Main(string[] args)
        {
            Number number;
            number.Amount = 3.3m;

            Console.WriteLine("The amount is: " + number.Amount);

            Console.ReadLine();
        }
        struct Number
        {
            public decimal Amount;
        }
    }
}
