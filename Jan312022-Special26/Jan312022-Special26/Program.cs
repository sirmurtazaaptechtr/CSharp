using System;

internal class Program
{
    static void Main()
    {
        //program to accept two integers and check whether they are equal or not
        //int a, b;
        //Console.Write("Enter First Number:");
        //a = int.Parse(Console.ReadLine());
        //Console.Write("Enter Second Number:");
        //b = int.Parse(Console.ReadLine());

        //if(a == b)
        //{
        //    Console.WriteLine("{0} and {1} are equal",a,b);
        //}
        //else
        //{
        //    Console.WriteLine("{0} and {1} are not equal",a, b);
        //}
        //program to check whether a given number is positive or negative.
        //int num;
        //Console.Write("Enter any Number:");
        //num = int.Parse(Console.ReadLine());
        //if(num < 0)
        //{
        //    Console.WriteLine("{0} is negative number.",num);
        //}
        //else if(num == 0)
        //{
        //    Console.WriteLine("{0} is neutral", num);
        //}
        //else
        //{
        //    Console.WriteLine("{0} is positive number.", num);
        //}
        //program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
        //int age;
        //Console.Write("Enter Your age:");
        //age = int.Parse(Console.ReadLine());

        //if(age >= 18)
        //{
        //    Console.WriteLine("Ja chun le apna banda .");
        //}
        //else
        //{
        //    Console.WriteLine("bara ho ke aa {0} saal baad ", 18 - age);
        //}
        //program to read the value of an integer num and display the value of flag is 1 when num is larger than 0, 0 when num is 0 and -1 when num is less than 0.

        int num, flag = 0;
        Console.Write("Enter any number:");
        num = int.Parse(Console.ReadLine());

        if(num == 0)
        {
            flag = 0;
        }else if(num > 0)
        {
            flag = 1;
        }else
        {
            flag = -1;
        }
        Console.WriteLine("flag = {0}", flag);

        Console.Read();
    }
}

