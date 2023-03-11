using System;

internal class Program
{
    static void Main()
    {
        int num, rem;
        Console.Write("Enter any Number:");
        num = int.Parse(Console.ReadLine());

        rem = num % 2;

        if(rem == 0)
        {
            Console.WriteLine("{0} is even number.",num);
        }
        else
        {
            Console.WriteLine("{0} is odd number",num);
        }

        Console.Read();

    }
}

