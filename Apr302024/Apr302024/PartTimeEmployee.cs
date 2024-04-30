using System;

namespace Apr302024
{
    internal class PartTimeEmployee : Employee
    {
        public float HourlyRate { get; set; }

        public override void PrintFullName()
        {
            Console.WriteLine($"Full Name : {FirstName} {LastName} - Temp");
        }

        public new void Print()
        {
            Console.WriteLine($"ID : {Id}\nFull Name : {FirstName} {LastName}\nEmail : {Email}\nAnnualSalary : PKR {HourlyRate*8*365}/=\n");
        }
    }
}
