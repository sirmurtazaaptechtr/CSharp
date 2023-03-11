using System;

internal class Program
{
    static void Main()
    {
        int a = 4, b = 6,c = 9,d = 12;

        Program.PrintNumbers(a, b, c, d);

    }
    public static void PrintNumbers(int num1,params int[] Numbers)
    {
        foreach( int num in Numbers)
        {
            Console.Write("{0}, ",num);
            
        }        
    }
}

