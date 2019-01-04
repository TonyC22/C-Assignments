using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_and_WhileDo
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the coolest number between 20 and 30");
            int userInput = Convert.ToInt32(Console.ReadLine());
            bool correctNumber = false;


            while (!correctNumber)
            {
                switch (userInput)
                {
                    case 23:
                        Console.WriteLine("Nope try again");
                        Console.WriteLine("What is the coolest number between 20 and 30");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 22:
                        Console.WriteLine("Bingo!");
                        correctNumber = true;
                        break;
                    default:
                        Console.WriteLine("Nope try again");
                        Console.WriteLine("What is the coolest number between 20 and 30");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            Console.ReadLine();

            //Console.WriteLine("What is the coolest number between 20 and 30");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //bool correctNumber = false;

            //do
            //{
            //    switch (userInput)
            //    {
            //        case 23:
            //            Console.WriteLine("Nope try again");
            //            Console.WriteLine("What is the coolest number between 20 and 30");
            //            userInput = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 22:
            //            Console.WriteLine("Bingo!");
            //            correctNumber = true;
            //            break;
            //        default:
            //            Console.WriteLine("Nope try again");
            //            Console.WriteLine("What is the coolest number between 20 and 30");
            //            userInput = Convert.ToInt32(Console.ReadLine());
            //            break;

            //    }

            //}
            //while (!correctNumber);

            //Console.ReadLine();
        }
    }
}

