using System;



internal class Program
{
    static void Main()
    {
        int age = 0;

        Console.Write("Enter your age in Years : ");
        //age = int.Parse(Console.ReadLine());
        bool isConverted = int.TryParse(Console.ReadLine(), out age);

        if (isConverted)
        {
            Console.WriteLine("Conversion Successful");
            Console.WriteLine("You are {0} years old", age);    
        }
        else
        {
            Console.WriteLine("Invalid Input!\nTry Again.");
        }
            
    }
}
