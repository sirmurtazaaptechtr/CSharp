using System;

namespace Mar262024
{
    internal class Program
    {
        static void Method1 ()
        {
            Console.WriteLine("This is method 1");
        }
        static int Method2 (int number)
        {
            int square = number * number;
            return square;
        }
        static void Method3 (int age, string firstName, string lastname = "") 
        {
            string fullName = string.Concat(firstName, " ", lastname).Trim();
            Console.WriteLine($"Dear {fullName}, you are {age} years old");
        }
        static void Main()
        {
            int num, sq;

            Method1 ();
            Method1 ();
            
            num = 12;
            sq = Method2(num);
            Console.WriteLine($"The square of {num} is {sq}");

            num = 49;            
            Console.WriteLine($"The square of {num} is {Method2(num)}");

            Method3(18, "Yusra", "Hussain");
            Method3(20, "Umaima");
            Method3(17, "Khadija","Imran");
            Method3(firstName: "Hassan", lastname: "Raza", age: 16);

        }
    }
}
