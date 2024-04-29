using System;

namespace Apr292024MH
{
    class PartTimeEmployee : Employee
    {
        public float HourlyRate { get; set; }

        public new void Print()
        {
            Console.WriteLine($"Employee ID : {EmpId}\nFull Name : {FirstName} {LastName}\nEmail : {Email}\nSalary/Month : PKR {HourlyRate * 8 * 7 * 4}/= ");
        }
        public override void DisplayFullName()
        {
            Console.WriteLine($"{FirstName} {LastName} - Part Time Employee");
        }
    }
}
