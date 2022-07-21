﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employeeOne = new Employee() { FirstName = "test2", LastName = "Employee" };
            Employee employeeTwo = new Employee() { FirstName = "test1", LastName = "Employee" };
            Console.WriteLine(employeeOne == employeeTwo);
            Console.WriteLine(employeeOne == employeeOne);
            Console.Read();
        }
    }
}
