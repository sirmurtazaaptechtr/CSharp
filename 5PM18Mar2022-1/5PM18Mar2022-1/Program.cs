using System;

internal class Program
{
    static void Main()
    {
        Program p = new Program();

        Console.Write("Enter First Number : ");
        int FN = int.Parse(Console.ReadLine());
        Console.Write("Enter Second Number : ");
        int SN = int.Parse(Console.ReadLine());

        int res = p.addTwoNumbers(FN, SN);
        Console.WriteLine("{0} + {1} = {2}", FN, SN, res);

    }
    public int addTwoNumbers(int a, int b)
    { 
        int c = a + b;
        return c;
    }
}
