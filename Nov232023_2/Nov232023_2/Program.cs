using System;
using BPTR = BigProject.TeamRabia;
using BigProject.TeamSaad;
using BPTZ = BigProject.TeamZubair;

namespace Nov232023_2
{
    internal class Program
    {
        static void Main()
        {
            BPTR.Class1.Print();
            MyClass.Print();
            BPTZ.Class1.Print();
        }
    }
}
namespace BigProject
{
    namespace TeamRabia
    {
        class Class1
        {
            public static void Print() 
            {
                Console.WriteLine("This is Team Rabia");
            }
        }
    }
    namespace TeamSaad
    {
        class MyClass
        {
            public static void Print()
            {
                Console.WriteLine("This is Team Saad");
            }
        }
    }
    namespace TeamZubair
    {
        class Class1
        {
            public static void Print()
            {
                Console.WriteLine("This is Team Zubari");
            }
        }
    }
}
