using System;

internal class Program
{
    static void Main()
    {
        int a=10,b=5,c,d;
        Program.AddSub(a, b, out c, out d);

        Console.WriteLine("First Number = {0} and Second Number = {1}", a, b);
        Console.WriteLine("Sum = {0} and Diff = {1}", c, d);

    }
    public static void AddSub(int num1, int num2, out int add ,out int sub)
    {
        add = num1+num2;
        sub = num1-num2;        
    }
}