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
            bool stopLoop = false;
            do
            {
                Console.WriteLine("Please type true");
                if (Console.ReadLine() == "true")
                {
                    Console.WriteLine("loop ends");
                    stopLoop = true;
                }
                else
                {
                    Console.WriteLine("you misspelled true, try again.");
                }
            }
            while (!stopLoop);
            Console.Read();

        }
    }
}
