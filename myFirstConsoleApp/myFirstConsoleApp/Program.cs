using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("What is your name?");
        string fullName = Console.ReadLine();

        Console.WriteLine("How old are you?");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Dear {0}, you are {1} years old.", fullName, age);
        
        Console.Read();
    }
}

