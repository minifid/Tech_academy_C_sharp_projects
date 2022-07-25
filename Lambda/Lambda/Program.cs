using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { Id = 1, FirstName = "Joe", LastName = "smith" };
            Employee employee2 = new Employee() { Id = 2, FirstName = "Joe", LastName = "smith" };
            Employee employee3 = new Employee() { Id = 3, FirstName = "Jack", LastName = "smith" };
            Employee employee4 = new Employee() { Id = 4, FirstName = "John", LastName = "smith" };
            Employee employee5 = new Employee() { Id = 5, FirstName = "Jason", LastName = "smith" };
            Employee employee6 = new Employee() { Id = 6, FirstName = "Adam", LastName = "smith" };
            Employee employee7 = new Employee() { Id = 7, FirstName = "Michael", LastName = "smith" };
            Employee employee8 = new Employee() { Id = 8, FirstName = "Mike", LastName = "smith" };
            Employee employee9 = new Employee() { Id = 9, FirstName = "Zach", LastName = "smith" };

            List<Employee> employees = new List<Employee>();

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);
            employees.Add(employee7);
            employees.Add(employee8);
            employees.Add(employee9);

            List<string> names = new List<string>();
            string fullname;
            foreach (Employee employee in employees) 
            {
                if (employee.FirstName == "Joe")
                {
                    fullname = employee.FirstName + " " + employee.LastName + " " + employee.Id;
                    names.Add(fullname);
                    Console.WriteLine(fullname);
                }
            }

            List<Employee> newList = employees.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee.Id + " " + employee.FirstName + " " + employee.LastName);
            }



            Console.Read();
        }
    }
}
