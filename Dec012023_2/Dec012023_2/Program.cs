using System;
namespace Dec012023_2
{
    class Student
    {
        public string FirstName = "Aptech";
        public string LastName = "Learning";
        public virtual void Print()
        {
            Console.WriteLine("{0} {1}", FirstName, LastName);
        }
    }
    class PrimaryStudent : Student
    {
        public override void Print()
        {            
            Console.WriteLine("{0} {1} - Primary", FirstName, LastName);
        }
    }
    class SecondaryStudent : Student
    {
        public override void Print()
        {
            Console.WriteLine("{0} {1} - Secondary", FirstName, LastName);
        }
    }
    internal class Program
    {
        static void Main()
        {
            Student s1 = new Student();
            PrimaryStudent s2 = new PrimaryStudent();
            SecondaryStudent s3 = new SecondaryStudent();

            Student s4 = new PrimaryStudent();
            Student s5 = new SecondaryStudent();

            s1.Print();
            s2.Print();
            s3.Print();
            s4.Print();
            s5.Print();
            
        }
    }
}