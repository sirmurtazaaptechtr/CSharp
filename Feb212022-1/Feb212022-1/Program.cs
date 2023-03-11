using System;
internal class Program
{
    //Value Parameters
    //public static void Main()
    //{
    //    int i = 10;

    //    SimpleMethod(i);

    //    Console.WriteLine(i);

    //    Console.Read();

    //}
    //public static void SimpleMethod(int j)
    //{
    //    j = j - 5;
    //}

    //Reference Parameters
    //public static void Main()
    //{
    //    int i = 10;

    //    SimpleMethod(ref i);

    //    Console.WriteLine(i);

    //    Console.Read();

    //}
    //public static void SimpleMethod(ref int j)
    //{
    //    j = j - 5;
    //}

    //Out Parameters
    //public static void Main()
    //{
    //    int a, b, sum, product;
    //    a = 10;
    //    b = 20;
    //    sum = 0;
    //    product = 0;

    //    CalcMethod(a, b, out sum, out product);

    //    Console.WriteLine("Sum = {0} and Product = {1}", sum, product);
    //    Console.Read();
    //}
    //public static void CalcMethod(int i, int j, out int add, out int mul)
    //{

    //    add = i + j;
    //    mul = i * j;
    //}

    //Parameters Array
    public static void Main()
    {
        int[] NumArr = new int[5];

        NumArr[0] = 10;    
        NumArr[1] = 20;    
        NumArr[2] = 30;    
        NumArr[3] = 40;
        NumArr[4] = 50;

        paramMethod("Murtaza", NumArr);
        //param2Method(1, 2, 3, 4, 5, 6, 7, 8, 9);
        param2Method();
        Console.Read();
    }
    public static void paramMethod(string name,params int[] Numbers)
    {
        Console.WriteLine("{0}'s Array has {1} elements",name, Numbers.Length);
        foreach(int num in Numbers)
        {
            Console.WriteLine(num);
        }
    }
    public static void param2Method(params int[] Numbers)
    {
        Console.WriteLine("Our Array has {0} elements", Numbers.Length);
        foreach(int num in Numbers)
        {
            Console.WriteLine(num);
        }
    }

}