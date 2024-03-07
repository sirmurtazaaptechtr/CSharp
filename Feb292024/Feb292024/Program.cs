using System;

namespace Feb292024
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Aptech Student Database");

            Console.Write("Enter Your Full Name : ");
            string fullName = Console.ReadLine();

            Console.Write("Enter Your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Are you a Pakistani (true/false) : ");
            bool isPaki = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter your Fees : ");
            double fees = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dear {0}, you are {1} years old. You are a {2} Pakistani and you fees is PKR {3}/=",fullName,age,isPaki,fees);

        }
    }
}
