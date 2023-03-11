using System;

namespace Jun082022_1
{
    internal class Program
    {
        static void Main()
        {
            int num = 10;

            Console.WriteLine("The number is "+num);
            Console.WriteLine("The number is {0}",num);

            string name;
            int age;

            Console.Write("Enter Your Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Your age : ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hi {0}, you are {1} years old. ",name,age);
        }
    }
}
