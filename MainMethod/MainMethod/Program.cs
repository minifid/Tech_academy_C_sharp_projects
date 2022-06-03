using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main()
        {
            int num = myClass.addition(5);
            Console.WriteLine(num);
            int num2 = myClass.addition(1.5m);
            Console.WriteLine(num2);
            int num3 = myClass.addition("5");
            Console.WriteLine(num3);
            int num4 = myClass.addition("test");
            Console.WriteLine(num4);

            Console.Read();

        }
    }
}
