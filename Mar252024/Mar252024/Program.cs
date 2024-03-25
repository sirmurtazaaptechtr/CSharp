using System;
using System.Runtime.Remoting.Lifetime;

namespace Mar252024
{
    internal class Program
    {
        static void MyMethod1()
        {
            Console.WriteLine("This is my method 1");
        }
        static int MyMethod2(int num)
        {
            return num * num;
        }
        static void MyMethod3(int age, string fistName,string lastName = "") 
        {
            Console.WriteLine($"Dear {fistName} {lastName}, You are {age} years old.");
        }
        static void MyMethod4(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }
        
        static void Main()
        {
            MyMethod1 ();
            int num = 5;
            Console.WriteLine($"Square of {num} is {MyMethod2(num)}");
            num = 17;
            Console.WriteLine($"Square of {num} is {MyMethod2(num)}");    
            num = 21;
            Console.WriteLine($"Square of {num} is {MyMethod2(num)}");
            MyMethod3(32, "Ali", "Raza");
            MyMethod3(23, "Urooj", "Shafi");
            MyMethod3(18, "Khizar", "Mansoor");
            MyMethod3(18, "Affan");
            MyMethod4(child3: "Ali", child1: "Faisal", child2: "Ahmed");
        }
    }
}
