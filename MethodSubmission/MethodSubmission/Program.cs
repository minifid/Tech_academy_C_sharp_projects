using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string uInput = Console.ReadLine();// created a variable so I can reuse it
            try
            {
                int num1 = Convert.ToInt32(uInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("first entry must be a number");
                Console.Read();
                Environment.Exit(0);
            }
           
            Console.WriteLine("Please hit enter or insert a number, then hit enter");


            try
            {
                int num1 = Convert.ToInt32(uInput);
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(myClass.addition(num1, num2));
            }
            catch (FormatException)
            {
                int num1 = Convert.ToInt32(uInput);
                Console.WriteLine(myClass.addition(num1));
            }
            
            Console.Read();
        }
    }
}
