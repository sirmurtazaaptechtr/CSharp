using System;

namespace Mar042024
{
    internal class Program
    {
        static void Main()
        {
            int x, y, z;
            x = 10;
            y = 20;
            z = x + y;

            Console.WriteLine(x + " + " + y + " = " + z);// concatination method
            Console.WriteLine("{0} + {1} = {2}", x, y, z);// placeholder method
            Console.WriteLine("{1} + {0} = {2}", x, y, z);// placeholder method
        }
    }
}
