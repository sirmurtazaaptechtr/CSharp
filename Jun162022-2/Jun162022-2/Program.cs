using System;
internal class Program
{
    static void Main()
    {
        Console.Write("Enter 1st Number : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter 2nd Number : ");
        int num2 = int.Parse(Console.ReadLine());
 showOptions:
        Console.Write("1.Add\n2.Sub\n3.Mul\n4.Div\n5.Exit\nEnter Your Choice(1 - 5) : ");
        int op = int.Parse(Console.ReadLine());
        switch (op)
        {
            case 1:
                Console.WriteLine("{0} + {1} = {2}",num1,num2,num1 + num2);
                break ;
            case 2:
                Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
                break ;
            case 3:
                Console.WriteLine("{0} X {1} = {2}", num1, num2, num1 * num2);
                break ;
            case 4:
                Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
                break;
            case 5:
                Console.WriteLine("Thank You");
                break;
            default:
                Console.WriteLine("Invalid Input!\ntry again...");
                goto showOptions;
        }
    }
}