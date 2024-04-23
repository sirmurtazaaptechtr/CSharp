using System;

namespace Apr232024
{
    internal class Program
    {
        static void Main()
        {
            Student s1 = new Student();
            s1.Id = 1;
            s1.Name = "Yusra Khan";
            s1.ObtMarks = 73f;

            Console.WriteLine($"ID : {s1.Id}\nName : {s1.Name}\nPercentage : {s1.ObtMarks/s1.MaxMarks*100}%");
        }
    }
}
