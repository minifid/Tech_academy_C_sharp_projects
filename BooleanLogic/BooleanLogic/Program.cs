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
            //asks age and saves it as an int
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            //asks for a dui and if response is y yes true or t sets hasDUI to true
            Console.WriteLine("Have you ever had a DUI");
            string dui = Console.ReadLine().ToLower();
            bool hasDUI = (dui == "y" || dui == "yes" || dui == "true" || dui == "t");

            //gets number of speeding tickets
            Console.WriteLine("How many speeding tickets do you have");
            int tickets = Convert.ToInt32(Console.ReadLine());

            //prints results
            Console.WriteLine("Results");
            Console.WriteLine("What is your age\n" + age);
            Console.WriteLine("Have you ever had a DUI?\n" + hasDUI);
            Console.WriteLine("How many speeding tickets do you have.\n" + tickets);
            //makes sure user is 16 or older with no DUIs and 3 or less tickets
            bool canHaveLicense = (age > 15 && hasDUI == false && tickets <= 3);
            Console.WriteLine("Qualified\n" + canHaveLicense);

            Console.Read();
        }
    }
}
