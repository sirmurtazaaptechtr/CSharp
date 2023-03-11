using System;
namespace Feb022023_1
{
    internal class Program
    {
        static void Main()
        {
            /*
            int[] numbers = new int[10];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0}. Enter Number :",i+1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Displaying Numbers ... ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("{0}. {1}",i+1,numbers[i]);
            }
            */
            int TotalCoffeeCost = 0;
            Console.Write("Welcome to Coffee Coffee\nMenu\n1 - Small\n2 - Regular\n3 - Large\nEnter Your Choice (1-3): ");
            int UserChoice = int.Parse(Console.ReadLine());
            switch (UserChoice)
            {
                case 1:
                    TotalCoffeeCost += 1;
                    break;
                case 2:
                    TotalCoffeeCost += 2;
                    break;

                case 3:
                    TotalCoffeeCost += 3;
                    break;

                default:
                    Console.WriteLine("Invalid Choice i.e. \"{0}\"", UserChoice);
                    break;
            }
            Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);
            Console.WriteLine("Thank Your for visiting Coffee Coffee");
        }
    }
    /// <summary>
    /// Jo Chooran likhna hai likh do koi tenshun nahi hai
    /// ye sara chooran is my Class se jur jaye gaa...
    /// </summary>
    public class myClass
    {
    }
}
