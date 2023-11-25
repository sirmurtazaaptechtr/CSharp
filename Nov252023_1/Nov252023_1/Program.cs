using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

namespace Nov252023_1
{
    internal class Program
    {
        static void Main()
        {
            Program.Print();
            PATA.Class1.Print();
            PATB.Class1.Print();

        }
        public static void Print()
        {
            Console.WriteLine("This is Main Team");
        }
    }
}
