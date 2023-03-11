using System;
internal class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;

        Console.WriteLine("InsideMain BeforeSwap->a={0} and b={1}", a, b);
        Program.swap(ref a, ref b);
        Console.WriteLine("InsideMain AfterSwap->a={0} and b={1}", a, b);
    }
    public static void swap (ref int a, ref int b)
    {
        Console.WriteLine("InsideSwap BeforeSwap->a={0} and b={1}", a, b);
        int temp;
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("InsideSwap AfterSwap->a={0} and b={1}", a, b);
    }
}