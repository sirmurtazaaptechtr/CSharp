using System;


namespace Jun072022_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\'Single Quote\'");
            Console.WriteLine("\"Double Quote\"");
            Console.WriteLine("C:\\Users\\murtaza\\source\repos");
            Console.WriteLine(@"C:\Users\murtaza\source\repos");
            string str = "\u0048\u0065\u006C\u006F";
            Console.WriteLine("\t"+str+"!");
            Console.WriteLine("\t{0}!",str);
            Console.WriteLine("\tAbdullah\u0020\"2022\"");            
            str = "\u0041\u0070\u0070\u006C\u0065";
            Console.WriteLine(str);
            string path = @"C:\Users\murtaza\source\repos";
            bool found = true;
            if (found)
            {
                Console.WriteLine("File Path : \'{0}\'", path);
            }
            else
            {
                Console.WriteLine("File not found!\a");
            }
            Console.WriteLine("C# is a powerful programming language");
            Console.WriteLine("C# is powerful");
            Console.WriteLine("programming language");
            Console.Write("C# is powerful ");
            Console.WriteLine("programming language");

            string FullName;
            int age;

            Console.Write("Enter Full Name : ");
            FullName = Console.ReadLine();
            Console.Write("Enter age in Years : ");            
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hi {0}, you are {1} years old.",FullName,age);
        }
    }
}
