using System;

namespace May072024
{
    class PartTimeEmployee : Employee
    {
        public float HourlyRate { get; set; }

        public override void PrintDetails()
        {
            Console.WriteLine($"ID : {Id}\nFull Name : {FirstName} {LastName}\nWeekly Salary : PKR {HourlyRate * 8 * 7}/= ");
        }
    }
}
