using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter a number to be used in math operations.");
            int num = Convert.ToInt32(Console.ReadLine());
            //applies the corresponding math operation to the user input
            Console.WriteLine(MyClass.multiply(num));
            Console.WriteLine(MyClass.addition(num));
            Console.WriteLine(MyClass.subtract(num));

            Console.Read();
        }
    }
}
