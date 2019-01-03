using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Name = "Tony";
            //string Job = "Nope";
            //string work = "Better get to work then.";

            //string Concatenate = "Do you, " + Name +  ", Have a Job? " + Job + ". \n " + work ;
            //Concatenate = Concatenate.ToUpper();
            //Console.WriteLine(Concatenate);
            //Console.ReadLine();


            StringBuilder sb = new StringBuilder();
            sb.Append("How much wood \n Could a wood chuck chuck \n if a wood chuck \n could chuck wood");
            Console.WriteLine(sb);
            Console.ReadLine();




        }
    }
}
