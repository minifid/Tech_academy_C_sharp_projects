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
            string[] myArray = new string[] { "0", "5", "6", "4", "2", "14" };
            Console.WriteLine("please choose which index you want to change from the below array (0-5) \n0, 5, 6, 4, 2, 14");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the new value");
            myArray[index] = Console.ReadLine();
            Console.WriteLine("This is the value at index " + index + " has been changed");
            Console.Read();
        }
    }
}
