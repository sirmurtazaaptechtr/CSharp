using System;

namespace May072024
{
    internal class Program
    {
        static void Main()
        {
            FullTimeEmployee fte1 = new FullTimeEmployee();
            fte1.Id = 1;
            fte1.FirstName = "Umaima";
            fte1.LastName = "Abdul Qadir";
            fte1.MonthlySalary = 175000f;
            fte1.PrintDetails();

            PartTimeEmployee pte1 = new PartTimeEmployee();
            pte1.Id = 2;
            pte1.FirstName = "Anshara";
            pte1.LastName = "Rizwan";
            pte1.HourlyRate = 950f;
            pte1.PrintDetails();
        }
    }
}