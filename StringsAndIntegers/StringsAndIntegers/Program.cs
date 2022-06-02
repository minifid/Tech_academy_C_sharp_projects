using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main()
        {
            List<int> myList = new List<int>() {100, 50, 20, 44, 68};
            Console.WriteLine("enter a number to divide the following numbers by. \n 100, 50, 20, 44, 68");
            try
            {
                int uInput = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < myList.Count; i++)
                {
                    Console.WriteLine(myList[i] + " divided by " + uInput + " equals " + myList[i] / uInput);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please only type a number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by 0");
            }
            finally
            {
                Console.WriteLine("Out of try catch block");
                Console.Read();
            }
        }
    }
}
