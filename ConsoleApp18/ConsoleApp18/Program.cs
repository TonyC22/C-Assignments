using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> example = new List<string>() { "xda", "dda", "xda" };
            List<string> nedw = new List<string>();


            foreach (var item in example)
            {
                if (nedw.Contains(item))
                    Console.WriteLine(item + " duplicate");
                nedw.Add(item);
                Console.ReadLine();
            }
        }
    }
}
