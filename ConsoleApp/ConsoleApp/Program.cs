using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            bool stopLoop1 = false;
            bool stopLoop2 = false;
            do
            {
                Console.WriteLine("Please type true");
                if (Console.ReadLine() == "true")
                {
                    Console.WriteLine("loop ends");
                    stopLoop1 = true;
                }
                else
                {
                    Console.WriteLine("you misspelled true, try again.");
                }
            }
            while (!stopLoop1);

            while (!stopLoop2)
            {
                Console.WriteLine("Please type yes");
                if (Console.ReadLine() == "yes")
                {
                    Console.WriteLine("loop ends");
                    stopLoop2 = true;
                }
                else
                {
                    Console.WriteLine("you misspelled true, try again.");
                }
            }
            Console.Read();

        }
    }
}
