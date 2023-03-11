using System;

namespace Mar042023_1
{
    public class Employee
    {
        string _firstName;
        string _lastName;

        public Employee()
            :this("John","Doe")
        {
            //this._firstName = "John";
            //this._lastName = "Doe";
        }
        public Employee(string FirstName,string LastName)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }
        public void PrintEmployeeName()
        {
            string FullName = this._firstName+" "+this._lastName;
            Console.WriteLine("FullName = {0}", FullName);
        }
        ~Employee()
        {
            Console.WriteLine("Memory is Free!");
        }
    }
    internal class Program
    {
        static void Main()
        {
            Employee e1 = new Employee("Hamza", "Malik");
            e1.PrintEmployeeName();

            Employee e2 = new Employee();
            e2.PrintEmployeeName();
        }
    }
}
