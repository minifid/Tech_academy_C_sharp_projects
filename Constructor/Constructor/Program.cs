using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string school = "Tech Acadamey";
            var student = "Nathan";
            chaining name = new chaining(student);
            Console.WriteLine(name.LastName);
            Console.Read();
        }
    }
}
