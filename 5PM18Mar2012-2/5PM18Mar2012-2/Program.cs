using System;

internal class Program
{
    static void Main()
    {
        int a, b, c;
        a = b = c = 0;        
        Program.setValueMethod(out a, out b, out c);
        Console.WriteLine("a={0}, b={1} and c={2}", a, b, c);

        int i = 10;
        int j = 17;
        Program.swap(i,j,out i, out j);
        Console.WriteLine("i = {0}, j = {1}", i, j);

    }
    public static void setValueMethod (out int p, out int q, out int r)
    {
        p = 10;
        q = 11;
        r = 12;
    }
    public static void swap(int x, int y, out int a, out int b)
    {
        int temp;
        temp = x;
        x = y;
        y = temp;

        a = x;
        b = y;
    }
}