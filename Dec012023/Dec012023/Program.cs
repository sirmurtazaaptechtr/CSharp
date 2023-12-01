using System;
namespace Dec012023
{
    class Student
    {
        public string FirstName = "Aptech";
        public string LastName = "Learning";
        public void Print () 
        {
            Console.WriteLine ("{0} {1}",FirstName,LastName);
        }
    }
    class PrimaryStudent : Student
    {
        public new void Print()
        {
            //base.Print ();
            Console.WriteLine ("{0} {1} - Primary", FirstName, LastName);
        }
    }
    class SecondaryStudent : Student 
    {
        public new void Print()
        {
            Console.WriteLine("{0} {1} - Secondary", FirstName, LastName);
        }
    }
    internal class Program
    {
        static void Main()
        {
            Student s1 = new Student();
            //PrimaryStudent s2 = new PrimaryStudent();
            Student s2 = new PrimaryStudent();
            SecondaryStudent s3 = new SecondaryStudent();
            s1.Print();
            s2.Print();
            //((Student)s2).Print();
            s3.Print();
        }
    }
}