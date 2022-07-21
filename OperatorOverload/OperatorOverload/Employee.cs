using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator== (Employee employee1, Employee employee2)
        {
            if ((employee1.FirstName == employee2.FirstName) && (employee1.LastName == employee2.LastName))
            {
                return true;
            } else
            {
                return false;
            }
        }
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            if ((employee1.FirstName != employee2.FirstName) || (employee1.LastName != employee2.LastName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
