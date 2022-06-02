using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison_program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous income Comparison Program");
            Console.WriteLine("Person 1\nInsert Hourly Rate");
            int p1Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert Number of weekly hours");
            int p1Hours = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Person 2\nInsert Hourly Rate");
            int p2Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert Number of weekly hours");
            int p2Hours = Convert.ToInt32(Console.ReadLine());

            int p1Salary = p1Hours * 52 * p1Rate;
            int p2Salary = p2Hours * 52 * p2Rate;
            bool p1MakesMore = p1Salary > p2Salary;
            Console.WriteLine("Annual salary of Person 1:\n" + p1Salary);
            Console.WriteLine("Annual salary of Person 2:\n" + p2Salary);
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + p1MakesMore);

            Console.Read();
        }
    }
}
