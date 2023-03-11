using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

internal class Program
{
    static void Main()
    {
        PATA.ClassA.Print();
        PATB.ClassA.Print();
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print() 
            {
                Console.WriteLine("This is Team A Message");
            }
        }
    }
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("This is Team B Message");
            }
        }
    }
}
