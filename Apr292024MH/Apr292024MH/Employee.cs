using System;

namespace Apr292024MH
{
    class Employee
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public void Print()
        {
            Console.WriteLine($"Employee ID : {EmpId}\nFull Name : {FirstName} {LastName}\nEmail : {Email}");
        }
        public virtual void DisplayFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
