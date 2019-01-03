using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge;
            int userTickets;
            bool DUI;



            Console.WriteLine("What is your age?");
            userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("True or False, Have you ever had a DUI?");
            DUI = bool.Parse(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            userTickets = int.Parse(Console.ReadLine());

            Console.WriteLine("Qualified?");
            if (DUI == true)
                Console.WriteLine("false");
                    else
            Console.WriteLine((+userAge >= 15) && +userTickets <= 3);
            Console.ReadLine();








        }
    }
}
