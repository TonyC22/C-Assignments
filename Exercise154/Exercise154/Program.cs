using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\H39J61\Logs\log.txt", true))
            {
                file.WriteLine(userInput);
            }
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\H39J61\Logs\log.txt");
            System.Console.WriteLine("Contents of log.txt = ");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
