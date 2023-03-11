using System;
internal class Program
{
    static void Main()
    {
        int a = 4,b = 6;
        Program p = new Program();
        Console.WriteLine("BS : a={0},b={1}", a, b);
        p.Swap(a, b);//calling instance Method
        Console.WriteLine("AS : a={0},b={1}", a, b);
        Console.WriteLine("BS : a={0},b={1}", a, b);
        Program.MasterSwap(ref a, ref b);//calling  static Method
        Console.WriteLine("AS : a={0},b={1}", a, b);
    }    
    public void Swap(int num1, int num2)//value Parameters
    {
        Console.WriteLine("BS : num1={0},num2={1}", num1, num2);
        int temp;
        temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine("AS : num1={0},num2={1}",num1,num2);
    }
    public static void MasterSwap(ref int num1, ref int num2)//reference Parameters
    {
        Console.WriteLine("BS : num1={0},num2={1}", num1, num2);
        int temp;
        temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine("AS : num1={0},num2={1}", num1, num2);
    }
}