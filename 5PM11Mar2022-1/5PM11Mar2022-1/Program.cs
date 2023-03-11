using System;

internal class Program
{
    static void Main()
    {
        //for(int i = 10; i > 0; i--)
        //{
        //    Console.WriteLine("{0}. My Name is Murtaza.",i);
        //}

        //int j = 1;
        //while (j <= 10)
        //{
        //    Console.WriteLine(j+". My name is Murtaza.");
        //    j++;
        //}

        int k = 1;
        Console.Write("Enter Table Number :");
        int tab = int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("{0} X {1} = {2}.",tab,k,tab*k);
            k++;
        }while (k <= 10);

    }
}

