using System;
using MPA = MyProject.TeamA;
using MPB = MyProject.TeamB;
internal class Program
{
    public static void Main()
    {
        //MyProject.TeamA.MyClass.Print();
        //MyProject.TeamB.MyClass.Print();
        MPA.MyClass.Print();
        MPB.MyClass.Print();

        Console.Read();
    }
}
namespace MyProject
{
    namespace TeamA
    {
        public class MyClass
        {
            public static void Print()
            {
                Console.WriteLine("Team A effort");
            }
        }
    }
}
namespace MyProject
{
    namespace TeamB
    {
        public class MyClass
        {
            public static void Print()
            {
                Console.WriteLine("Team B effort");
            }
        }
    }
}
