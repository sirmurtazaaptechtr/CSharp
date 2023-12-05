using System;
namespace Dec042023
{
    class Calc
    {
        public static void Sum (int a, int b)
        {
            Console.WriteLine("1. Result : {0}", a + b);
        }
        public static void Sum(float a, float b)
        {
            Console.WriteLine("2. Result : {0}", a + b);
        }
        public static void Sum (int a, int b, int c)
        {
            Console.WriteLine("3. Result : {0}", a + b + c);
        }
        public static void Sum (int a, int b, out int c)
        {
            c = a + b;
            Console.WriteLine("4. Result : {0}", a + b);
        }

    }
    internal class Program
    {
        static void Main()
        {
            Calc.Sum(1, 2);
            Calc.Sum(1.2f, 2);
            Calc.Sum(1.2f, 2.4f);
            Calc.Sum(1, 5.4f);
            Calc.Sum(2, 4, 6);

            int x;
            Calc.Sum(4, 7, out x);

            Console.WriteLine("X : {0}", x);
        }
    }
}
