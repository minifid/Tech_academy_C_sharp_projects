using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num * 50);
            Console.WriteLine("enter another number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num + 25);
            Console.WriteLine("enter another number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num / 12.5);
            Console.WriteLine("enter another number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num > 50);
            Console.WriteLine("enter another number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num % 7);
            Console.Read();
        }
    }
}
