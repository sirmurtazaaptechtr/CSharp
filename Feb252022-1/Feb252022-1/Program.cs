using System;
using MPA = MyProject.TeamA;
using MPB = MyProject.TeamB;
internal class Program
{
    public static void Main()
    {
        MPA.MyClass.Print();
        MPB.MyClass.Print();
        
        Console.Read();
    }
}