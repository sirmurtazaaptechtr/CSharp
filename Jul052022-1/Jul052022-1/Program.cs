using System;
public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;

    public void PrintFullName()
    {
        Console.WriteLine("Mr./Ms./Mrs. {0} {1}. How do you do? ",FirstName,LastName);
    }
}
public class FullTimeEmployee : Employee
{
    public float YearlySalary;
    public new void PrintFullName()
    {
        //base.PrintFullName();
        Console.WriteLine("Mr./Ms./Mrs. {0} {1}. You are Permanent Employee ", FirstName, LastName);
    }
}
public class PartimeEmployee : Employee
{
    public float HourlyRate;
}
internal class Program
{
    static void Main()
    {
        FullTimeEmployee fte = new FullTimeEmployee();
        fte.FirstName = "Abdullah";
        fte.LastName = "Khan";
        fte.Email = "abc@xyz.com";
        fte.PrintFullName();

        PartimeEmployee pte = new PartimeEmployee();
        pte.FirstName = "Huzaifa";
        pte.LastName = "Ali";
        pte.PrintFullName();

        Employee e = new FullTimeEmployee();
        e.FirstName = "Ali";
        e.LastName = "Baba";
        e.PrintFullName();
    }
}

