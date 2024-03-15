using System;
using System.ComponentModel;

namespace Mar152024
{
    internal class Program
    {
        static void Main()
        {
            int number,remainder,divisor;
            bool isPrime = true;
            Console.Write("Enter any Number : ");
            number = int.Parse(Console.ReadLine());
            // For Even and ODD
            remainder = number % 2;

            if(remainder == 0)
            {
                Console.WriteLine($"{number} is Even");
            }
            else
            {
                Console.WriteLine($"{number} is Odd");
            }

            // For PRIME NUMBER
            divisor = 2;
            while(divisor < number)
            {
                if(number % divisor == 0)
                {
                    isPrime = false;
                    break;
                }
                divisor++;
            }

            if(isPrime)
            {
                Console.WriteLine($"{number} is PRIME");
            }
            else
            { 
                Console.WriteLine($"{number} is Not-PRIME"); 
            }

            //float marks,percentage;
            //Console.Write("Enter Obtained Marks Out of 75 : ");
            //marks = float.Parse(Console.ReadLine());

            //percentage = (float)Math.Round(marks / 75 * 100,2);
            //Console.WriteLine($"Percentage : {percentage}%");

            //if (percentage >= 80)
            //{
            //    Console.WriteLine("Grade : A+");
            //}
            //else if(percentage >= 70)
            //{
            //    Console.WriteLine("Grade : A");
            //}
            //else if (percentage >= 60)
            //{
            //    Console.WriteLine("Grade : B");
            //}
            //else if (percentage >= 50)
            //{
            //    Console.WriteLine("Grade : C");
            //}
            //else if (percentage >= 40)
            //{
            //    Console.WriteLine("Grade : D");
            //}
            //else
            //{
            //    Console.WriteLine("Grade : No-Grade");
            //}
        }
    }
}
