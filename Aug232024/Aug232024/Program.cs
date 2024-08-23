using System;

namespace Aug232024
{
    internal class Program
    {
        static void Main()
        {
            // Comparison Operators

            int x = 5;
            int y = 3;
            int z = 64;
            int a = -64;
            float f = 22.0f/7;

            Console.WriteLine("{0} > {1} = {2}", x, y, x > y);
            Console.WriteLine("{0} < {1} = {2}", x, y, x < y);
            Console.WriteLine("{0} >= {1} = {2}", x, y, x >= y);
            Console.WriteLine("{0} <= {1} = {2}", x, y, x <= y);
            Console.WriteLine("{0} == {1} = {2}", x, y, x == y);
            Console.WriteLine("{0} != {1} = {2}", x, y, x != y);

            // Logical Operators

            Console.WriteLine("true AND true = {0}", true && true);
            Console.WriteLine("true AND false = {0}", true && false);
            Console.WriteLine("false AND true = {0}", false && true);
            Console.WriteLine("false AND false = {0}", false && false);
            Console.WriteLine("true OR true = {0}", true || true);
            Console.WriteLine("true OR false = {0}", true || false);
            Console.WriteLine("false OR true = {0}", false || true);
            Console.WriteLine("false OR false = {0}", false || false);
            Console.WriteLine("NOT true = {0}", !true);
            Console.WriteLine("NOT false = {0}", !false);

            // C# Math
            Console.WriteLine(Math.Max(x, y));
            Console.WriteLine(Math.Min(x, y));
            Console.WriteLine(Math.Sqrt(z));
            Console.WriteLine(Math.Abs(a));
            Console.WriteLine(Math.Round(f, 2));
            Console.WriteLine("{0:N2}", f);
            Console.WriteLine("{0:C2}", f);

            // C# Strings
            string text = "Hello World";
            Console.WriteLine(text);
            Console.WriteLine(text.Length);
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            string firstname = "Sadaf";
            string lastname = "Irshad";

            string fullname = firstname + " " + lastname;
            fullname = string.Concat("Ms.", firstname," ",lastname);
            Console.WriteLine(fullname);
        }
    }
}
