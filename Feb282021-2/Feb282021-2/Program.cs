using System;
class Employee
{
    public string _firstName;
    public string _lastName;   

    public void PrintFullName()
    {
        Console.WriteLine("Full Name = {0} {1}",this._firstName,this._lastName);
    }
}
class FullTimeEmp : Employee
{
    public float _YearlySalary;
}
class PartTimeEmp : Employee
{
    public float _HourlyRate;
}

internal class Program
{
    static void Main()
    {
        PartTimeEmp PTE = new PartTimeEmp();
        PTE._firstName = "Moiz";
        PTE._lastName = "Ghazali";
        PTE.PrintFullName();

        FullTimeEmp FTE = new FullTimeEmp();
        FTE._firstName = "Yazdan";
        FTE._lastName = "Khan";
        FTE.PrintFullName();

        Console.Read();
    }
}

