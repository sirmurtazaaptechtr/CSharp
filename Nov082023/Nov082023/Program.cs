using System;
namespace Nov082023
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter your full name : ");
            string FullName = Console.ReadLine();
            Console.Write("Enter your age : ");
            int Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Welcome " + FullName + ". You are " + Age + " years old.");
            Console.WriteLine("Welcome {0}. You are {1} years old.", FullName, Age);
        }
    }
}