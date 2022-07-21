using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; //Instatiates the object Employee with the name employee and sets first name as sample and last and student
            employee.SayName();
            Console.Read();
        }
    }
}
