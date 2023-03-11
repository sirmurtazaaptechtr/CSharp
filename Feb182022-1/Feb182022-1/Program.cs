using System;
internal class Program
{
    public static void Main()
    {
        Program obj = new Program();
        obj.evenNumbers(42, 72);
        obj.oddNumbers(1, 15);
        int a,b,c;
        a = 10;
        b = 20;
        c = Program.addTwoNumbers(a, b);
        Console.WriteLine("the sum of {0} and {1} is {2}",a,b,c);

        Console.Read();
    }
    public void evenNumbers(int start,int end)
    {
        Console.WriteLine("List of Even Numbers from {0} to {1}", start, end);
        int cnt = start;
        while (cnt <= end)
        {
            if(cnt%2 == 0)
            {
                Console.WriteLine(cnt);
            }
            cnt++;
        }
    }
    public void oddNumbers(int start,int end)
    {
        Console.WriteLine("List of ODD Numbers from {0} to {1}",start,end);
        for(int cnt = start; cnt <= end; cnt++)
        {
            if(cnt%2 != 0)
            {
                Console.WriteLine(cnt);
            }
        }
    }
    public static int addTwoNumbers(int Num1, int Num2)
    {
        return Num1+Num2;
    }
}

