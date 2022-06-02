using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main()
        {
            int[] numArray = new int[] { 0, 5, 6, 4, 2, 14 };
            string[] myArray = new string[] { "George", "Fred", "Bob"};
            Console.WriteLine("please choose which index you want to change from the below array (0-2) \nGeorge, Fred, Bob");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index >= myArray.Length)
            {
                Console.WriteLine("There is no index at that location");
            }
            else
            {
                Console.WriteLine("Please enter the new value");
                myArray[index] = Console.ReadLine();
                Console.WriteLine("The value at index " + index + " has been changed");
            }
            Console.WriteLine("Select an index (0-5)");
            int numIndex = Convert.ToInt32(Console.ReadLine());
            if (numIndex >= numArray.Length)
            {
                Console.WriteLine("There is no index at that location");
            }
            else
            {
                Console.WriteLine(numArray[numIndex]);
            }
            Console.Read();
        }
    }
}
