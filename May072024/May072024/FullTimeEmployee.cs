using System;

namespace May072024
{
    class FullTimeEmployee : Employee
    {
        public float MonthlySalary { get; set; }

        public override void PrintDetails()
        {
            Console.WriteLine($"ID : {Id}\nFull Name : {FirstName} {LastName}\nMonthly Salary : PKR {MonthlySalary}/=");
        }
    }
}
