using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int pkgWeight;
            int pkgWidth;
            int pkgHeight;
            int pkgLength;
            int pkgCost;
            int pkgSum;


            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            pkgWeight = Convert.ToInt32(Console.ReadLine());
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            Console.WriteLine("Please enter the package width:");
            pkgWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            pkgHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            pkgLength = Convert.ToInt32(Console.ReadLine());
            if (pkgWidth + pkgHeight + pkgLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            pkgSum = (pkgWidth + pkgLength + pkgHeight);
            pkgCost = (pkgSum * pkgWeight / 100);
            Console.WriteLine("Your estimated total for shipping this package is: $" + pkgCost );
            Console.ReadLine();

            


        }
    }
}
