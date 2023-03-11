using System;

internal class Program
{
    static void Main()
    {
        int[] Numbers = new int[3];

        //Numbers[0] = 10;
        //Numbers[1] = 20;
        //Numbers[2] = 30;

        Program.myMethod(5, 9, 10, 109, 108);
        //Program.myMethod(Numbers);
        //Program.myMethod();

    }
    public static void myMethod(int a,params int[] numbers)
    {
        Console.WriteLine("There are {0} elements in the array",numbers.Length);

        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
