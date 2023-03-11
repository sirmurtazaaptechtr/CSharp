using System;
internal class Program
{
    static void Main()
    {
        int a = 4, b = 5; 
        Program prog = new Program();
        prog.print();
        int sum = prog.add(a, b);
        Console.WriteLine("{0} + {1} = {2}",a,b,sum);
        prog.EvenNumbers();

        Program.ShowName("Abdullah");
    }

    public void print()
    {
        Console.WriteLine("Hi, there");
    }
    public int add (int num1, int num2)
    {
        int res = num1 + num2;
        return res;
    }
    public void EvenNumbers()
    {
        int start = 0;
        while(start <= 20)
        {
            Console.WriteLine(start);
            start = start+2;
        }
    }
    public static void ShowName(string FullName)
    {
        Console.WriteLine("Hi {0}, how are you?",FullName);
    }
}