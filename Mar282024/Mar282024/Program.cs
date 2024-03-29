using System;

namespace Mar282024
{
    internal class Program
    {
        static void MyMethod () 
        {
            Console.WriteLine("This is my Method");
        }
        static void MyMethod (string name)
        {
            Console.WriteLine($"Dear {name}, how are you?");
        }
        static void MyMethod (int age, string name)
        {
            Console.WriteLine($"Dear {name}, how are you? you are {age} years old.");
        }

        public void TheMethod () {
            Console.WriteLine("This is the method.");
        }

        static void Main()
        {
            MyMethod();
            MyMethod("Umaima");
            MyMethod(18,"Huzaifa");
            MyMethod(name:"Yusra Khan",age:18);

            Program p1 = new Program();
            p1.TheMethod();
        }
    }
}
