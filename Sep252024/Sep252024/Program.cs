using System;

namespace Sep252024
{
    class Employees
    {
        // Class members
        public string firstname;     // field
        public string lastname;     // field
        public int age;             // field
        public string gender;       // field

        
        public void Print ()        // Method
        {
            Console.WriteLine($"Dear {firstname} {lastname}, you are {age}years old {gender}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees emp1 = new Employees();
            Employees emp2 = new Employees();
            Employees emp3 = new Employees();
            Employees emp4 = new Employees();

            emp1.firstname = "Aptech";
            emp1.lastname = "Learning";
            emp1.age = 16;

            emp2.firstname = "Sadaf";
            emp2.lastname = "Irshad";
            emp2.age = 22;

            emp3.firstname = "Javeria";
            emp3.lastname = "Shafique";
            emp3.age = 20;


            emp4.firstname = "Uzair";
            emp4.lastname = "Ahmed";
            emp4.age = 20;


            emp1.Print();
            emp2.Print();
            emp3.Print();
            emp4.Print();

            emp4.lastname = "Ahmed Ali";
            emp4.Print();



        }
    }
}
