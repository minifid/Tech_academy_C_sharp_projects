using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    enum Week
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool isDayValid = false;
            int myVar;
            Console.WriteLine("Please enter a day of the week");
            while (!isDayValid)
            {     
            string day = Console.ReadLine();
                try
                {
                    myVar = (int)Enum.Parse(typeof(Week), day);
                    Console.WriteLine("Thank you. The day is: " + (Week)myVar);
                    isDayValid = true;
                }
                catch
                {
                    Console.WriteLine("please enter a valid day of the week");
                }
            }

            Console.Read();
        }
    }
}
