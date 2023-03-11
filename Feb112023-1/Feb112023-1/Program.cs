using System;
namespace Feb112023_1{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("This Solution example methods");
            Program p1 = new Program();

            p1.Method1();            

            int data1 = p1.Method2();
            Console.WriteLine("Method2 Returns => {0}", data1);

            int data2 = p1.Method3(14, 17);
            Console.WriteLine("Method2 Returns => {0}", data2);

            Program.Method();            
        }
        public static void Method()
        {
            Console.WriteLine("This method dosn't require any instance vaiable");
        }
        public void Method1 ()
        {
            Console.WriteLine("This is Function/Method 1");
        }
        public int Method2 ()
        {
            Console.WriteLine("This is method 2 and will return a value");
            return 174;
        }
        public int Method3 (int num1, int num2)
        {
            Console.WriteLine("This is method 3 it will take input and will return a value");
            return num1 + num2;
        }       
    }
}