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
            Employee employee = new Employee() { FirstName = "Test", LastName = "Employee"};
            employee.SayName();
            IQuittable quittable = new Employee() { FirstName = "quittable", LastName = "Employee"};
            quittable.Quit();
            Console.Read();
        }
    }
}
