using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise165
{
    class Program
    {
        static void Main(string[] args)
            {
            int userAge;
                try
                {
                    Console.WriteLine("Please enter your age.");
                    userAge = Convert.ToInt32(Console.ReadLine());
                    if (userAge <= 0)
                    {
                        throw new InvalidAgeException(string.Format("Please enter your real age."));
                    }
                    DateTime userBirthDate = DateTime.Now.AddYears(-userAge);
                    Console.WriteLine("You were born in " + userBirthDate.ToString("yyyy"));
                    Console.ReadLine();
                }
                catch (InvalidAgeException)
                {
                    Console.WriteLine("Impossible age, Please enter your real age.");
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Whoops! There was an Error, please contact your Systems Administrator.");
                    Console.ReadLine();
                }
            }
    }
}
