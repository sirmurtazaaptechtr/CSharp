using System;
using P007AT = Project007.AlphaTeam;
using P007DT = Project007.DeltaTeam;

class Program
{
    static void Main()
    {
        //Project007.AlphaTeam.myClass.print();
        //Project007.DeltaTeam.myClass.print();
        P007DT.myClass.print();
        P007AT.myClass.print();
    }
}
namespace Project007
{
    namespace AlphaTeam
    {
        public class myClass
        {
            public static void print()
            {
                Console.WriteLine("This method is developed by alpha team...");
            }
        }
    }
}
namespace Project007
{
    namespace DeltaTeam
    {
        public class myClass
        {
            public static void print()
            {
                Console.WriteLine("This method is developed by Delta team...");
            }
        }
    }
}