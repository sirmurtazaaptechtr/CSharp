using System;

namespace Aug212024
{
    internal class Program
    {
        static void Main()
        {
            // C# User Input

            string fullname;
            int age, num1, num2, num3;

            Console.Write("Enter Full Name : ");// displays a meaningful message for input
            fullname = Console.ReadLine();// takes user input

            Console.Write("Enter your age : ");
            // age = int.Parse(Console.ReadLine());
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hi {0}, You are {1} years old.", fullname, age);

            // C# Operators

            Console.Write("Enter any Number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = num1 + 100;
            num3 = num1 + num2;

            Console.WriteLine("{0}, {1}, {2}",num1, num2, num3);

            Console.Write("Enter First Number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Second Number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}",num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}",num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}",num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}",num1, num2, num1 / num2);
            Console.WriteLine("{0} % {1} = {2}",num1, num2, num1 % num2);            
        }
    }
}
