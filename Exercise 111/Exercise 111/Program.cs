using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Exercise1
    {
        public static int SumItself(int number)
        {
            return number + number;
        }

        public static int MultiplyItself(int number)
        {
            return number * number;
        }

        public static int AddOne(int number)
        {
            return number + 1;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Input a parameter: ");
            string userInput = Console.ReadLine();
            int parameter = Convert.ToInt32(userInput);

            Console.WriteLine("\nThe sum of the number with itself is: " + SumItself(parameter));
            Console.WriteLine("The multiplication of the number with itself is: " + MultiplyItself(parameter));
            Console.WriteLine("The sum of the number with 1 is: " + AddOne(parameter));

            Console.ReadLine();
        }
    }

}
