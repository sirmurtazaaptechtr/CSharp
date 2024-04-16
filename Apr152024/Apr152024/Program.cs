using System;

namespace Apr152024
{
    internal class Program
    {
        static void TheMethod1() 
        {
            Console.WriteLine("This is The Method");
        }
        static void TheMethod2(string FullName, int age) 
        {
            Console.WriteLine($"Hello {FullName}, you are {age} years old.");
        }
        static void TheMethod3(string FullName) 
        {
            Console.WriteLine($"{FullName} Khan");
        }        
        static void Main()
        {
            TheMethod1();
            TheMethod2("Moiz", 21);
            TheMethod2("Khizar", 18);
            TheMethod2("Saad", 18);
            TheMethod2("Shoaib", 20);
            TheMethod2("Faizan", 22);
            TheMethod3("Amir");
            TheMethod3("Salman");
            TheMethod3("Shahrukh");
            TheMethod3("Zubair");
            TheMethod3("Saif Ali");
        }
    }
}
