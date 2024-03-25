using System;

namespace Mar222024
{
    internal class Program
    {
        static void Main()
        {
            //string[] names;
            //names = new string[] { "Shoaib", "Moiz", "Ahmed", "Ali", "Affan", "Saad", "Mujtaba", "Junaid" };

            string[] names = { "Shoaib", "Moiz", "Ahmed", "Ali", "Affan", "Saad", "Mujtaba", "Junaid" };
            names[3] = "Muhammad Ali";

            //Console.WriteLine($"Hi {names[3]}");
            foreach (string name in names) 
            {
                Console.WriteLine($"Dear {name}, How are you?");
            }

            Array.Sort(names);
            foreach (string name in names)
            {
                Console.WriteLine($"Dear {name}, How are you?");
            }
        }
    }
}
