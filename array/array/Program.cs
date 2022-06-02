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
            //asks for an index of array myArray and displays value
            string[] myArray = new string[] { "George", "Fred", "Bob"};
            Console.WriteLine("please choose which index you want to change from the below array (0-2) \nGeorge, Fred, Bob");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index >= myArray.Length)
            {
                Console.WriteLine("There is no index at that location");
            }
            else
            {
                Console.WriteLine("The value at index " + index + " " + myArray[index]);
            }

            //asks for an index of array numArray and displays value
            Console.WriteLine("Select an index (0-5)");
            int[] numArray = new int[] { 0, 5, 6, 4, 2, 14 };
            int numIndex = Convert.ToInt32(Console.ReadLine());
            if (numIndex >= numArray.Length)
            {
                Console.WriteLine("There is no index at that location");
            }
            else
            {
                Console.WriteLine(numArray[numIndex]);
            }

            //asks for an index for the list myList and displays the value
            List<string> myList = new List<string>() { "text", "more text", "even more text" };
            Console.WriteLine("Enter an index (0-2).");
            int listIndex = Convert.ToInt32(Console.ReadLine());
            if (listIndex >= myList.Count)
            {
                Console.WriteLine("There is no index at that location");
            }
            else
            {
                Console.WriteLine(myList[listIndex]);
            }
            Console.Read();
        }
    }
}
