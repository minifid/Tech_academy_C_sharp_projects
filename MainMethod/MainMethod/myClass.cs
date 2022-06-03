using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class myClass
    {
        //accepts int returns int
        public static int addition(int x)
        {
            return x + 10;
        }

        //accepts decimal returns int
        public static int addition(decimal x)
        {
            return Convert.ToInt32(x + 5);
        }

        //accepts string returns int returns 0 if given text instead of a number
        public static int addition(string x)
        {
            try
            {
            return Convert.ToInt32(x + 5);
            }
            catch (FormatException)
            {
                Console.WriteLine("cannot convert text to int returning 0");
                return 0;
            }
        }
    }
}
