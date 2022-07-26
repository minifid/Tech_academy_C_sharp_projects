using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDateTimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter a number");

            double num = Convert.ToDouble(Console.ReadLine());
            
            DateTime currentTime = DateTime.Now;
            DateTime futureHours = currentTime.AddHours(num);
            
            Console.WriteLine(futureHours);
            Console.Read();
        }
    }
}
