using System;
using PA = Projects.ProjectA;
using PB = Projects.ProjectB;
namespace Feb182023_1
{
    internal class Program
    {
        static void Main()
        {
            PA.ClassA.Method1();
            PB.ClassA.Method1();
            ProjectA.Class1.Method();
            ProjectB.Class1.Method();
        }
    }
}
namespace Projects
{
    namespace ProjectA
    {
        class ClassA
        {
            public static void Method1()
            {
                Console.WriteLine("This is Method1 of Program Class of ProjectA");
            }
        }
    }
    namespace ProjectB
    {
        class ClassA
        {
            public static void Method1()
            {
                Console.WriteLine("This is Method1 of Program Class of ProjectB");
            }
        }
    }
}