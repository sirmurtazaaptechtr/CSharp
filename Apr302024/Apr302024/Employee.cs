using System;

namespace Apr302024
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual void PrintFullName()
        {
            Console.WriteLine($"Full Name : {FirstName} {LastName}");
        }

        public void Print()
        {
            Console.WriteLine($"ID : {Id}\nFull Name : {FirstName} {LastName}\nEmail : {Email}\n");
        }
    }
}
