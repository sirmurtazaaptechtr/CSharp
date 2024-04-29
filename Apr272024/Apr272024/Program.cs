using System;

namespace Apr272024
{
    internal class Program
    {
        static void Main()
        {
            FullTimeEmployee fte1 = new FullTimeEmployee();
            fte1.EmpId = 1;
            fte1.FirstName = "Aptech";
            fte1.LastName = "Learning";
            fte1.Email = "info@aptech-learning.com.pk";
            fte1.MonthlySalary = 245765f;
            fte1.Print();
            
            PartTimeEmployee pte1 = new PartTimeEmployee();
            pte1.EmpId = 2;
            pte1.FirstName = "Tariq";
            pte1.LastName = "Road";
            pte1.Email = "contact@aptech-learning.com.pk";
            pte1.HourlyRate = 1250f;
            pte1.Print();

            //Employee e1 = new PartTimeEmployee();
            PartTimeEmployee e1 = new PartTimeEmployee();
            e1.EmpId = 3;
            e1.FirstName = "Test";
            e1.LastName = "Employee";
            e1.Email = "email@example.com";
            //e1.Print();
            ((Employee)e1).Print();
        }
    }
}