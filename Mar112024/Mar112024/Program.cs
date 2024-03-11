using System;
using System.Globalization;

namespace Mar112024
{
    internal class Program
    {
        static void Main()
        {
            float num1, num2;
            
            Console.Write("Enter First Number : ");
            num1 = float.Parse(Console.ReadLine());

            Console.Write("Enter Second Number : ");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
            Console.WriteLine($"{num1} ^ {num2} = {Math.Pow(num1,num2)}");

            Console.WriteLine($"num1 = {num1}");
            
            Console.WriteLine($"{num1}++ = {num1++}");
            Console.WriteLine($"num1 = {num1}");

            Console.WriteLine($"++{num1} = {++num1}");
            Console.WriteLine($"num1 = {num1}");

            Console.WriteLine($"{num1}-- = {num1--}");
            Console.WriteLine($"num1 = {num1}");

            Console.WriteLine($"--{num1} = {--num1}");
            Console.WriteLine($"num1 = {num1}");

            num1 += 2;
            Console.WriteLine($"num1+=2 = {num1}");
            num1 -= 2;
            Console.WriteLine($"num1-=2 = {num1}");
            num1 *= 2;
            Console.WriteLine($"num1*=2 = {num1}");
            num1 /= 2;
            Console.WriteLine($"num1/=2 = {num1}");
            num1 %= 2;
            Console.WriteLine($"num1%=2 = {num1}");

            Console.WriteLine($"num1 = {num1}, num2 = {num2}");
            Console.WriteLine($"num1({num1}) == num2({num2}) => {num1 == num2}");
            Console.WriteLine($"num1({num1}) != num2({num2}) => {num1 != num2}");
            Console.WriteLine($"num1({num1}) < num2({num2}) => {num1 < num2}");
            Console.WriteLine($"num1({num1}) > num2({num2}) => {num1 > num2}");
            Console.WriteLine($"num1({num1}) <= num2({num2}) => {num1 <= num2}");
            Console.WriteLine($"num1({num1}) >= num2({num2}) => {num1 >= num2}");

            double pi = 22.0d / 7;
            Console.WriteLine(pi);
            Console.WriteLine(Math.Round(pi));
            Console.WriteLine(Math.Round(pi,2));

            string text = "Moiz ur Rehman";
            Console.WriteLine($"\"{text}\" has {text.Length} characters in it.");
            Console.WriteLine($"\"{text.ToLower()}\"");
            Console.WriteLine($"\"{text.ToUpper()}\"");

            string firstName = "Ahmed";
            string lastName = "Raza";
            //string fullName = firstName + " " + lastName;
            //string fullName = string.Concat(firstName, " ", lastName);
            string fullName = $"{firstName} {lastName}";

            Console.WriteLine(fullName);
        }
    }
}
