using System;

internal class Program
{
    static void Main()
    {
        int TotalCoffeeCost = 0;

        Console.Write("1 - Small\n2 - Medium\n3 - Large\nEnter Choice : ");
        int UserChoice = int.Parse(Console.ReadLine());

        switch (UserChoice)
        {
            case 1:
                TotalCoffeeCost += 2;
                break;
            case 2:
                TotalCoffeeCost += 4;
                break;
            case 3:
                TotalCoffeeCost += 6;
                break;
            default:
                Console.WriteLine("Your Choice {0} is invalid!", UserChoice);
                break;
        }
        Console.WriteLine("Thank you for shopping with us.");
        Console.WriteLine("Total Bill = {0}",TotalCoffeeCost);
    }
}

