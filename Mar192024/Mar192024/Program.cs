using System;
using System.ComponentModel;

namespace Mar192024
{
    internal class Program
    {
        static void Main()
        {
            int tab, cnt;
            string ch = "y";
            Console.WriteLine("Welcome to The Table Program");
            do
            {
                Console.Write("Enter Table Number : ");
                tab = int.Parse(Console.ReadLine());

                for(cnt = 1; cnt <= 10; cnt++)
                {
                   Console.WriteLine($"{tab} x {cnt} = {tab*cnt}");
                }

                Console.Write("Do you want to display another table? (Y/N) : ");
                ch = Console.ReadLine().ToLower();
            }
            while( ch == "y" );
            Console.WriteLine("Thank Your for using Table Program...");

        }
    }
}
