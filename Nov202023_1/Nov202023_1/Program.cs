using System;
namespace Nov202023_1
{
    internal class Program
    {
        static void Main()
        {
            int a = 10; int b = 20;

            Program p = new Program(); // creating instance variable 'p' of 'Program' class

            Console.WriteLine("Call by Value Example");
            Console.WriteLine("Outside BS : (a, b)--->({0}, {1})", a, b);
            p.Swap1(a, b); // call by value
            Console.WriteLine("Outside AS : (a, b)--->({0}, {1})", a, b);

            Console.WriteLine("Call by Reference Example");
            Console.WriteLine("Outside BS : (a, b)--->({0}, {1})", a, b);
            p.Swap2(ref a, ref b);// call by reference
            Console.WriteLine("Outside AS : (a, b)--->({0}, {1})", a, b);
        }
        public void Swap1(int x, int y) 
        {
            Console.WriteLine("Inside BS : (x, y)--->({0}, {1})", x, y);
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("Inside AS : (x, y)--->({0}, {1})", x, y);
        }
        public void Swap2(ref int x, ref int y)
        {
            Console.WriteLine("Inside BS : (x, y)--->({0}, {1})", x, y);
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("Inside AS : (x, y)--->({0}, {1})", x, y);
        }
    }
}
