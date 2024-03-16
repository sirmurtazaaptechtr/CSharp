using System;


namespace Mar162024
{
    internal class Program
    {
        static void Main()
        {
            float num1, num2;
            int ch;
            string answer = "y";
            do
            {
                Console.Write("Enter First Number : ");
                num1 = float.Parse(Console.ReadLine());
                Console.Write("Enter Second Number : ");
                num2 = float.Parse(Console.ReadLine());

                Console.Write("1.ADD\n2.SUB\n3.MUL\n4.DIV\nEnter Your Choice (1-4) : ");
                ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
                        break;
                    case 4:
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

                Console.Write("Do you want to continue (Y/N) : ");
                answer = Console.ReadLine().ToLower();
            }while(answer == "y" || answer == "yes");
            Console.WriteLine("The End");

        }
    }
}
