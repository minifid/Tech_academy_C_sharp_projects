using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI");
            string dui = Console.ReadLine().ToLower();
            bool hasDUI = (dui == "y" || dui == "yes" || dui == "true" || dui == "t");

            Console.WriteLine("How many speeding tickets do you have");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Results");
            Console.WriteLine("What is your age\n" + age);
            Console.WriteLine("Have you ever had a DUI?\n" + hasDUI);
            Console.WriteLine("How many speeding tickets do you have.\n" + tickets);
            bool canHaveLicense = (age > 15 && hasDUI == false && tickets <= 3);
            Console.WriteLine("Qualified\n" + canHaveLicense);

            Console.Read();
        }
    }
}
