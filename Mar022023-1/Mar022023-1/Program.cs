using System;
namespace Mar022023_1
{
    class Customer
    {
        string _firstName;
        string _lastName;
        float _age;
        public Customer(string FirstName,string LastName,float Age)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
            this._age = Age;
            //Console.WriteLine("This is Constructor");
        }
        public void PrintFullName()
        {
            Console.WriteLine("Dear {0}, you are {1} years old.",this._firstName+" "+this._lastName,this._age);
        }
    }
    internal class Program
    {
        static void Main()
        {
            Customer c1 = new Customer("Jamal","Khan",18);
            c1.PrintFullName();

            Customer c2 = new Customer("Bandook","Khan",35);
            c2.PrintFullName();           
        }
    }
}