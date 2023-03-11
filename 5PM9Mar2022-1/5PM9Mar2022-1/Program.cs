using System;

internal class Program
{
    static void Main()
    {
        int year;
        Console.Write("Enter Year : ");
        year =  int.Parse(Console.ReadLine());
        /*
        A leap year is exactly divisible by 4 except for century years (years ending with 00).
        The century year is a leap year only if it is perfectly divisible by 400.
        A leap year is one which is divisible by 4 or 400 but not by 100.
        */
        if (year%4 == 0 && year%100 != 0 || year%400 ==0)
        {
            Console.WriteLine(year + " is Leap Year");
        }
        else
        {
            Console.WriteLine(year + " is not Leap Year");
        }
    }
}

