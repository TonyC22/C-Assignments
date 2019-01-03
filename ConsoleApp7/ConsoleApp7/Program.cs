using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {


            int p1Rate = 15;
            int p1Hours = 40;
            int p2Rate = 20;
            int p2Hours = 40;

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            Console.WriteLine(+p1Rate);
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine(+p1Hours);
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            Console.WriteLine(+p2Rate);
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine(+p2Hours);
            Console.WriteLine("Weekly Salary of Person 1:");
            Console.WriteLine(+p1Hours * 15);
            Console.WriteLine("Weekly Salary of Person 2:");
            Console.WriteLine(+p2Hours * 20);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(+p1Rate > +p2Rate);









            Console.ReadLine();











        }
    }
}
