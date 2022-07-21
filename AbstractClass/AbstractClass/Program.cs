using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.SayName();
            IQuittable quittable = new Employee();
            quittable.Quit();
            Console.Read();
        }
    }
}
