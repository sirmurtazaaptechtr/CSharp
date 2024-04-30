using System;

namespace Apr302024
{
    internal class Program
    {
        static void Main()
        {
            PartTimeEmployee e1 = new PartTimeEmployee();
            e1.Id = 1;
            e1.FirstName = "Anshara";
            e1.LastName = "Rizwan";
            e1.Email = "anshara@rizwan.com";
            e1.HourlyRate = 750;

            FullTimeEmployee e2 = new FullTimeEmployee();
            e2.Id = 2;
            e2.FirstName = "Zeeshan";
            e2.LastName = "Ahmed";
            e2.Email = "zeeshan@ahmed.com";
            e2.MonthlySalary = 175260;

            Employee e3 = new FullTimeEmployee();
            e3.Id = 3;
            e3.FirstName = "Faraz";
            e3.LastName = "Abbas";
            e3.Email = "faraz@abbas.com";            

            e1.Print();
            e2.Print();
            ((Employee)e2).Print();
            e3.Print();

            Employee[] employees = new Employee[3];

            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();

            employees[0].FirstName = "Zain ul";
            employees[0].LastName = "Abideen";

            employees[1].FirstName = "Hamza";
            employees[1].LastName = "Irfan";

            employees[2].FirstName = "Ali";
            employees[2].LastName = "Yousuf";

            foreach(Employee emp in employees)
            {
                emp.PrintFullName();
            }
        }
    }
}
