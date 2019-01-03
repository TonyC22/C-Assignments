using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("--Student Daily Report--");
            Console.WriteLine("What course are you on?");
            string Course = Console.ReadLine();
            char[] iCourse = Course.ToCharArray();
            Console.WriteLine(iCourse);
      
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pNumber = Convert.ToInt32(pageNumber);
            Console.WriteLine(pNumber);

            Console.WriteLine("Do you need help with anything? Please answer 'True' or 'False'.");
            string courseHelp;
            courseHelp = Console.ReadLine();
            Console.WriteLine(courseHelp);
            
            

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string pFeedback;
            pFeedback = Console.ReadLine();
            Console.WriteLine(pFeedback);

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string moreFeedback;
            moreFeedback = Console.ReadLine();
            Console.WriteLine(moreFeedback);

            Console.WriteLine("How many hours did you study today?");
            string studyTime = Console.ReadLine();
            int sTime = Convert.ToInt32(studyTime);
            Console.WriteLine(sTime);



            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
