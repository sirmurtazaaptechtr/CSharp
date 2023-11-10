using System;

namespace Nov072023
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter you name : ");
            string name = Console.ReadLine();
            Console.Write("Enter you age : ");
            int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Dear {0}, How do you do? you are {1} years old.", name, age);
            Console.WriteLine("Dear \"" + name + "\", How do you do?\nYou are " + age + " years old.");

        }
    }
}
