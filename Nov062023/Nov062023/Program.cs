using System;
using MySpace;
namespace Nov062023
{
    internal class Program
    {
        static int num = 15;
        static void Main(string[] args)
        {
            Console.WriteLine("This is my First C# Console Application.");
            MyClass.MyMethod();
            TheClass.greet("Ahsan Khan");
            int sq = squrer(num);
            Console.WriteLine("The square of {0} is {1}", num, sq);
        }
        public static int squrer (int number) 
        {
            int square = number * number;
            return square; 
        }
        
    }
}
namespace MySpace
{
    class MyClass
    {
        public static void MyMethod()
        {
            Console.WriteLine("This is my Method");
        }

    }
    class TheClass
    {
        public static void greet(string name)
        {
            Console.WriteLine("Dear {0}, Welcome to my Application.",name);
        }
    }
}