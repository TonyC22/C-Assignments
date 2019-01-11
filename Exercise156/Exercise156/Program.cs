using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise156
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);
            Console.WriteLine("Please enter in a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(currentDate.AddHours(userInput));
            Console.ReadLine();
        }
    }
}