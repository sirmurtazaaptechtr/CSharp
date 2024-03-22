using System;


namespace Mar212024
{
    internal class Program
    {
        static void Main()
        {
            

            //string[] names = {"Yusra","Anshara","Khadija","Huzaifa","Ali","Hassan","Hamza","Kashan","Zeeshan","Faizan"};

            string[] names;
            names = new string[] { "Yusra", "Anshara", "Khadija", "Huzaifa", "Ali", "Hassan", "Hamza", "Kashan", "Zeeshan", "Faizan" };

            names[4] = "Ali Yousuf Raza";

            //Console.WriteLine(names[3]);
            foreach (string name in names)
            {
                Console.WriteLine($"Dear {name}, How do you do?");
            }

            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };
        }
    }
}
