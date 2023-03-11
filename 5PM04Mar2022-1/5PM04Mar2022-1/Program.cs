using System;

internal class Program
{
    static void Main()
    {
        int[] ages = new int[5];
        string[] names = new string[5];
        int i;
        for(i = 0; i < 5; i++)
        {
            Console.Write("{0}. Enter your Name : ", i + 1);
            names[i] = Console.ReadLine();

            Console.Write("Enter age : ");
            ages[i] = int.Parse(Console.ReadLine());
        }
        for(i = 0; i < 5; i++)
        {
            Console.WriteLine("Hi {0}, you are {1} years old.", names[i], ages[i]);
        }
    }
}