using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixPartAssignment
{
    class Program
    {
        static void Main()
        {
            //part 1
            //first string will add the users text to the end of each of the string in myArray1
            string[] myArray1 = new string[] { "first", "second", "third" };
            Console.WriteLine("Please enter text to append to all elements of the array");
            string uInput = Console.ReadLine();
            // part 3
            for (int i=0; i < myArray1.Length; i++)
            {
                myArray1[i] = myArray1[i] + uInput;
            }
            for (int i = 0; i <= myArray1.Length - 1; i++)
            {
                Console.WriteLine(myArray1[i]);
            }
            //end part 3
            //end part 1

            //part 4
            //will use user input to search through myList and returns the first element that matches
            List<string> myList = new List<string>() { "George", "Fred", "Nathan" };
            Console.WriteLine("Please enter text to search by.");
            string search2 = Console.ReadLine().ToLower();
            bool noResults2 = true;
            for (int i = 0; i < myList.Count; i++)
            {
                if(myList[i].ToLower().Contains(search2))
                {
                    Console.WriteLine(myList[i] + " at index " + i);
                    if (noResults2) { noResults2 = false; }
                    break;
                }
            }
            if (noResults2)
            {
                Console.WriteLine("No elements in the array match your search.");
            }
            //end part 4

            //part 5
            //will use user input to search through myList2 and returns all matches
            List<string> myList2 = new List<string> { "George", "Fred", "Nathan", "George" };
            Console.WriteLine("Please enter text to search by.");
            string search3 = Console.ReadLine().ToLower();
            bool noResults3 = true;
            foreach (string value in myList)
            {
                if (value.ToLower().Contains(search3))
                {
                    Console.WriteLine(value);
                    if (noResults3) { noResults3 = false; }
                    
                }
            }
            if (noResults3)
            {
                Console.WriteLine("No elements in the array match your search.");
            }
            //end part 5

            //part 6
            //will go through myList2 and say if it is a duplicate or not
            Console.WriteLine("\ndisplays duplicates in myList2");
            int duplicateCount = 0;
            bool duplicate = false;
            foreach (string value in myList2)
            {
                duplicateCount = 0;
                foreach (string value2 in myList2)
                {
                    if (value == value2)
                    {
                        duplicateCount++;
                    }
                }
                _ = duplicateCount <= 1 ? duplicate = false : duplicate = true;
                Console.WriteLine("Is " + value + " a duplicate? " + duplicate);
            }
            //end part 6

            Console.Read();
        }
    }
}
