using System;


namespace Apr302024
{
    class FullTimeEmployee : Employee
    {
        public float MonthlySalary { get; set; }

        public override void PrintFullName()
        {
            Console.WriteLine($"Full Name : {FirstName} {LastName} - Permanent");
        }

        public new void Print()
        {
            //base.Print();
            Console.WriteLine($"ID : {Id}\nFull Name : {FirstName} {LastName}\nEmail : {Email}\nAnnualSalary : PKR {MonthlySalary*12}/=\n");
        }
    }
}
