using System;
internal class Program
{
    static void Main()
    {
        int year;
        Console.Write("Enter Year:");
        year = int.Parse(Console.ReadLine());

        if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        {
            Console.WriteLine("{0} is leap year having 366 days", year);
        }
        else
        {
            Console.WriteLine("{0} is common year having 365 days.", year);
        }
        Console.Read();
    }
}
