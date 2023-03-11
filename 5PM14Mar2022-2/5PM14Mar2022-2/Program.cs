using System;
internal class Program
{
    static void Main()
    {
        Console.Write("Which Operation You Want to Run\n1.Even Numbers\n2.Odd Numbers\n3.Square\nEnter Your Choice : ");
        int ch = int.Parse(Console.ReadLine());

        Program p1 = new Program();
        switch (ch)
        {
            case 1:
                Program.printEvenNumbers(10, 25);
            break;
            case 2:
                p1.printOddNumbers(10, 50);
            break;
            case 3:
                Console.Write("Enter Number : ");
                int num = int.Parse(Console.ReadLine());
                int square = p1.showSquare(num);
                Console.WriteLine("Square of {0} is {1} ",num,square);
            break;
            default:
                Console.WriteLine("Invalid Choice!");
            break;
        }
    }
    public static void printEvenNumbers(int start, int end)
    {
        Console.WriteLine("Displaying Even Numbers between {0} and {1}",start,end);
        for(int i = start; i <= end; i++)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    public void printOddNumbers(int start, int end)
    {
        Console.WriteLine("Displaying Odd Numbers between {0} and {1}", start, end);
        for (int i = start; i <= end; i++)
        {
            if(i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    public int showSquare(int number)
    {
        int sq = number * number;
        return sq;
    }
}

