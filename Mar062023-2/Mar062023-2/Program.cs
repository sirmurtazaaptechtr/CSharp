using System;
namespace Mar062023_2
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintEmpData()
        {
            Console.WriteLine("FullName : {0}\neMail : {1}", FirstName + " " + LastName, Email);
        }
    }
    public class FullTimeEmployee : Employee
    {
        public float YearSalary;
        public void PrintSalary()
        {
            Console.WriteLine("Monthly Salary = {0}", YearSalary / 12);
        }
    }
    public class PartTimeEmployee : Employee
    {
        public float HourRate;
        public void PrintSalary()
        {
            Console.WriteLine("Monthly Salary = {0}", HourRate * 8 * 5 * 4);
        }
    }
    internal class Program
    {
        static void Main()
        {
            FullTimeEmployee e1 = new FullTimeEmployee();
            e1.FirstName = "Sardar";
            e1.LastName = "Uzair";
            e1.Email = "solutionsardar@gmail.com";
            e1.YearSalary = 12345678f;

            e1.PrintEmpData();
            e1.PrintSalary();

            PartTimeEmployee e2 = new PartTimeEmployee();
            e2.FirstName = "Haleema";
            e2.LastName = "Faisal";
            e2.Email = "haleema@gmail.com";
            e2.HourRate = 1000f;

            e2.PrintEmpData();
            e2.PrintSalary();
        }
    }
}