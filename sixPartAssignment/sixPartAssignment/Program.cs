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
            //first string will add the users text to the end of each of the string in myArray1
            string[] myArray1 = new string[] { "first", "second", "third" };
            Console.WriteLine("Please enter text to append to all elements of the array");
            string uInput = Console.ReadLine();
            for (int i=0; i < myArray1.Length; i++)
            {
                myArray1[i] = myArray1[i] + uInput;
            }
            for (int i = 0; i <= myArray1.Length - 1; i++)
            {
                Console.WriteLine(myArray1[i]);
            }

            //will use user input to search through myArray2 and returns the first element that matches
            string[] myArray2 = new string[] { "George", "Fred", "Nathan" };
            Console.WriteLine("Please enter text to search by.");
            string search2 = Console.ReadLine().ToLower();
            bool noResults2 = true;
            for (int i = 0; i < myArray2.Length; i++)
            {
                if(myArray2[i].ToLower().Contains(search2))
                {
                    Console.WriteLine(myArray2[i] + " at index " + i);
                    if (noResults2) { noResults2 = false; }
                    break;
                }
            }
            if (noResults2)
            {
                Console.WriteLine("No elements in the array match your search.");
            }

            //will use user input to search through myArray3 and returns all matches
            string[] myArray3 = new string[] { "George", "Fred", "Nathan", "George" };
            Console.WriteLine("Please enter text to search by.");
            string search3 = Console.ReadLine().ToLower();
            bool noResults3 = true;
            for (int i = 0; i < myArray3.Length; i++)
            {
                if (myArray3[i].ToLower().Contains(search3))
                {
                    Console.WriteLine(myArray3[i] + " at index " + i);
                    if (noResults3) { noResults3 = false; }
                    
                }
            }
            if (noResults3)
            {
                Console.WriteLine("No elements in the array match your search.");
            }

            //will go through myArray3 and say if it is a duplicate or not
            Console.WriteLine("\n displays duplicates in myArray3");
            bool duplicate = false;
            for (int i=0; i<myArray3.Length; i++)
            {
                duplicate = false;
                for (int j=i+1; j<myArray3.Length; j++)
                {
                    if (myArray3[i] == myArray3[j])
                    {
                        duplicate = true;
                        break;
                    }
                }
                Console.WriteLine("Is " + myArray3[i] + " at index " + i + " a duplicate? " + duplicate);
            }

            Console.Read();
        }
    }
}
