using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("What is the package weight?");
            float weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package is to heavy.");
                Console.Read();
                Environment.Exit(0);
            }
            Console.WriteLine("What is the package width?");
            float width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the package height?");
            float height = Convert.ToInt32(Console.ReadLine());
            if (height + width > 50)
            {
                Console.WriteLine("Package is too big to be shipped.");
                Console.Read();
                Environment.Exit(0);
            }
            float total = width * height * weight / 100;
            Console.WriteLine("The cost is $" + total.ToString("0.00"));
            Console.Read();
        }
    }
}
