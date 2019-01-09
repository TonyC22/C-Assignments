using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise134
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Exercise134
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the current day of the week?");
            String input = Console.ReadLine();

            try
            {
                WeekDays WeekDay = (WeekDays)Enum.Parse(typeof(WeekDays), input, true);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }

            Console.ReadLine();
        }
    }
}
