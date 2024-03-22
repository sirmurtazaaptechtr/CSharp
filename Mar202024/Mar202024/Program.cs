using System;

namespace Mar202024
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome in Table Program");
            int tab,cnt;
            string ans = "y";

            do
            {
                Console.Write("Enter Table Number : ");
                tab = int.Parse(Console.ReadLine());

                for (cnt = 1; cnt <= 10; cnt++)
                {
                    Console.WriteLine($"{tab} x {cnt} = {tab * cnt}");
                }
                Console.Write("Press Y to continue and N to Exit (Y/N) : ");
                ans = Console.ReadLine().ToLower();
            } while (ans == "y");
            Console.WriteLine("Thnak You for using Table Program");
        }
    }
}
