using System;

internal class Program
{
    static void Main()
    {
        int CoffeeCost = 0;
        string CoffeeName;
        string SizeName;
        int CoffeeType;
        int CupSize;
        Console.WriteLine("~~~~~~~~~Welcome to 5PM CAFE~~~~~~~");
AskCoffeeAgain:
        Console.Write("\n\n1.FRAPPUCCINO.\n2.CARAMEL MACCHIATO.\n3.CAFÉ MOCHA.\n4.AMERICANO.\nSelect Your Cofee :");
        CoffeeType = int.Parse(Console.ReadLine());
        switch (CoffeeType)
        {
            case 1:
                CoffeeCost = 400;
                CoffeeName = "FRAPPUCCINO";
                break;
            case 2:
                CoffeeCost = 350;
                CoffeeName = "CARAMEL MACCHIATO";
                break;
            case 3:
                CoffeeCost = 300;
                CoffeeName = "CAFÉ MOCHA";
                break;
            case 4:
                CoffeeCost = 250;
                CoffeeName = "AMERICANO";
                break;
            default:
                Console.WriteLine("Invalid Choice!");
                goto AskCoffeeAgain;
        }
AskSizeAgain:
        Console.Write("\n\n1.Small.\n2.Medium.\n3.Large.\n4.Extra Large.\nSelect Your Cup Size :");
        CupSize = int.Parse(Console.ReadLine());
        switch (CupSize)
        {
            case 1:
                CoffeeCost += 0;
                SizeName = "Small";
                break;
            case 2:
                CoffeeCost += 5;
                SizeName = "Medium";
                break;
            case 3:
                CoffeeCost += 10;
                SizeName = "Large";
                break;
            case 4:
                CoffeeCost += 15;
                SizeName = "Extra Large";
                break;
            default:
                Console.WriteLine("Invalid Choice!");
                goto AskSizeAgain;
        }
        Console.WriteLine("\n\nCoffee Name = {0}\nCoffee Size = {1}\nCoffee Cost = PKR {2}/=",CoffeeName,SizeName, CoffeeCost);
    }
}