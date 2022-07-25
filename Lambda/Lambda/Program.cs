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
            //creates the employees
            Employee employee1 = new Employee() { Id = 1, FirstName = "Joe", LastName = "smith" };
            Employee employee2 = new Employee() { Id = 2, FirstName = "Joe", LastName = "smith" };
            Employee employee3 = new Employee() { Id = 3, FirstName = "Jack", LastName = "smith" };
            Employee employee4 = new Employee() { Id = 4, FirstName = "John", LastName = "smith" };
            Employee employee5 = new Employee() { Id = 5, FirstName = "Jason", LastName = "smith" };
            Employee employee6 = new Employee() { Id = 6, FirstName = "Adam", LastName = "smith" };
            Employee employee7 = new Employee() { Id = 7, FirstName = "Michael", LastName = "smith" };
            Employee employee8 = new Employee() { Id = 8, FirstName = "Mike", LastName = "smith" };
            Employee employee9 = new Employee() { Id = 9, FirstName = "Zach", LastName = "smith" };

            //creates the list of employees
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
            //creates a list of all employees with first name joe and print them to console
            foreach (Employee employee in employees) 
            {
                if (employee.FirstName == "Joe")
                {
                    names.Add(employee.Id + " " + employee.FirstName + " " + employee.LastName);
                    Console.WriteLine((employee.Id + " " + employee.FirstName + " " + employee.LastName);
                }
            }

            //uses a lamba expression to create a list of all employees with id greater than 5
            List<Employee> newList = employees.Where(x => x.Id > 5).ToList();

            //prints the list creates
            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee.Id + " " + employee.FirstName + " " + employee.LastName);
            }
            
            Console.Read();
        }
    }
}
