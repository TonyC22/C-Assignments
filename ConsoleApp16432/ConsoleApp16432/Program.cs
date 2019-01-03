using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16432
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Infinite Loop");

                if (Console.KeyAvailable)
                {
                    break;
                }
            }
        }
    }
}
