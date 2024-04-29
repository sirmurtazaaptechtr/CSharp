using System;

namespace Apr272024
{
    class Employee
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public void Print ()
        {
            Console.WriteLine($"Employee ID : {EmpId}\nFull Name : {FirstName} {LastName}\nEmail : {Email}");
        }
    }
}