using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_106
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                try
                {
                    List<int> numbers = new List<int>() { 20, 22, 40, 36 };
                    Console.WriteLine("Enter a number to divide each number in the list by");
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    foreach (int number in numbers)
                    {
                        int answer = number / userInput;
                        Console.WriteLine(answer);
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please type a whole number.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("You cannot divide by zero.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Program has exited the try/catch block");
            }

        }

    }
}
