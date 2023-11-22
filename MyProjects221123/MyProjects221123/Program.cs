using System;
using TeamA = ProjectA.TeamA;
using TeamB = ProjectA.TeamB;
namespace MyProjects221123
{
    internal class Program
    {
        static void Main()
        {
            TeamA.ClassA.Print();
            TeamB.ClassA.Print();            
        }
    }
}
namespace ProjectA
{
    namespace TeamA
    {
        public class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("This is Team A's Work");
            }
        }

    }
    namespace TeamB
    {
        public class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("This is Team B's Work");
            }
        }

    }
}
