using System;
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Thi is my First C# Console Application.");
        
        string name;
        Console.Write("Enter your Full Name : ");
        name = Console.ReadLine();

        int age;
        Console.Write("Enter you age : ");
        age = int.Parse(Console.ReadLine());

        //Console.WriteLine("My name is "+name+" and I am "+age+" years old.");
        Console.WriteLine("My name is {0} and I am {1} years old.", name,age);

        Console.Read();
    }
}