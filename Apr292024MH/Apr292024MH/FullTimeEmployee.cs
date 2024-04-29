using System;

namespace Apr292024MH
{
    class FullTimeEmployee : Employee
    {
        public float MonthlySalary { get; set; }

        public new void Print()
        {
            //base.Print();
            Console.WriteLine($"Employee ID : {EmpId}\nFull Name : {FirstName} {LastName}\nEmail : {Email}\nSalary/Month : PKR {MonthlySalary}/= ");
        }

        public override void DisplayFullName()
        {
            Console.WriteLine($"{FirstName} {LastName} - Full Time Employee");
        }
    }
}
