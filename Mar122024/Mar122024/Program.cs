using System;

namespace Mar122024
{
    internal class Program
    {
        static void Main()
        {
            float num1, num2, res;
            int op;

            Console.Write("Enter First Number : ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            num2 = float.Parse(Console.ReadLine());

            Console.Write("1. Addition\n2. Subtraction\n3. Multiplicaton\n4. Division\nEnter Your Choice(1-4) : ");
            op = int.Parse(Console.ReadLine());

            switch(op)
            {
                case 1:
                    res = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {res}");
                break;
                case 2:
                    res = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {res}");
                break;
                case 3:
                    res = num1 * num2;
                    Console.WriteLine($"{num1} X {num2} = {res}");
                break;
                case 4:
                    res = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {res}");
                break;
                default:
                    Console.WriteLine("Invalid Choice!");
                break;
            }
        }
    }
}
