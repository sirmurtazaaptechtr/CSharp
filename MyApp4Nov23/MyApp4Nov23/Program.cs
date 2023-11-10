using System;

namespace MyApp4Nov23
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("This is my C# Application");           
            Greetings("Ali","How are you?");
            Greetings("Khurram","You are very bad...");
        }

        static void Greetings(string name, string msg)
        {
            Console.WriteLine("Dear {0}, {1}",name,msg);
        }
        
    }
}
