using System;

namespace Apr162024
{
    internal class Program
    {
        static void MyMethod ()// Static Method
        {
            Console.WriteLine("This is my Method...");
        }
        void TheMethod () // Instance Method
        {
            Console.WriteLine("This is The Method");
        }
        static void Main()
        {
            // to execute static methods
            MyMethod ();
            Student.MyMethod ();

            // to execute instance methods
            Program p1 = new Program();
            Student s1 = new Student();
            Student s2 = new Student();
            
            p1.TheMethod ();
            s1.TheMethod ();

            s1._obt_marks = 150;
            Console.WriteLine($"{s1.ShowPercentage()}%");
            
            s2._obt_marks = 50;
            Console.WriteLine($"{s2.ShowPercentage()}%");
            Console.WriteLine($"{s2.ShowPercentage(37.68f)}%");
            Console.WriteLine($"{s2.ShowPercentage(337.68f, 500.00f)}%");
            
        }
    }
}
