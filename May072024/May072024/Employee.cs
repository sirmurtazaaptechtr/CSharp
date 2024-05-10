using System;

namespace May072024
{
    abstract class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }        

        public void PrintFullName ()
        {
            Console.WriteLine($"Full Name : {FirstName} {LastName}");
        }

        public abstract void PrintDetails();
    }
}
