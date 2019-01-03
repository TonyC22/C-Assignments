using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main()
        {
            List<string> names = new List<string>() { "MSI", "MSI", "AMD", "EVGA" };
            Console.WriteLine("Select text to search for in the List");
            string userInput = Console.ReadLine();
            bool x = false;
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].Contains(userInput))
                {
                    x = true;
                    Console.WriteLine("Match found : " + names[i]);
                    Console.ReadLine();
                }
            }
            if (x == false)
            {
                Console.WriteLine("No matches found");
                Console.ReadLine();
            }
        }
    }
}
