using System;
using PATA = ProjetA.TeamA;
using PATB = ProjectA.TeamB;
namespace Nov242023
{
    class Customer
    {
        string _firstName;
        string _lastName;
        int _age;
        float _salary;

        public void SetFirstName (string FirstName)
        {
            this._firstName = FirstName;
        }
        public void SetLastName (string LastName)
        {
            this._lastName = LastName;
        }
        public void SetAge (int Age)
        {
            this._age = Age;
        }
        public void SetSalary (float Salary)
        {
            this._salary = Salary;
        }

        public void Print() 
        {
            Console.WriteLine("First Name : {0}\nLast Name : {1}\nAge = {2}\nSalary = {3}", this._firstName, this._lastName, this._age, this._salary);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PATA.Class1.Print();
            PATB.Class1.Print();

            Customer C1 = new Customer();
            Customer C2 = new Customer();
            Customer C3 = new Customer();
            
            C1.SetFirstName("Muhammad");
            C1.SetLastName("Khurram");
            C1.SetAge(22);
            C1.SetSalary(2457.75f);

            C2.SetFirstName("Ahsan");
            C2.SetLastName("Khan");
            C2.SetAge(21);
            C2.SetSalary(1245.50f);
            
            C3.SetFirstName("Saqlain");
            C3.SetLastName("Dejwani");
            C3.SetAge(15);
            C3.SetSalary(2415.25f);

            C1.Print();
            C2.Print();
            C3.Print();
        }
    }
}