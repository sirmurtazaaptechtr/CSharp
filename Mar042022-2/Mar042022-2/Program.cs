using System;

public class Program
{
    public static void Main()
    {

        add(2, 3, 4);
    }
    public static void add( int a, int b,int[] c)
    {
        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
    }
    public static void add( int a, int b, int c)
    {
        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        Console.WriteLine("The last number is {0}", c);
    }
}

