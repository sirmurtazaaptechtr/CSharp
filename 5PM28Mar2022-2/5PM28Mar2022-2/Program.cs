using System;
class Employee
{
    string _firstName;
    string _lastName;
    string _email;

    public Employee(string FirstName, String LastName, string Email)
    {
        this._firstName = FirstName;
        this._lastName = LastName;
        this._email = Email;
    }
    public void printFullName()
    {
        Console.WriteLine("Dear, "+this._firstName + " " + this._lastName);
    }
    public void printEmailAddress()
    {
        Console.WriteLine("email Address = {0}", this._email);
    }
}
class FullTimeEmployee : Employee
{

    public float _yearlySalary;

    public FullTimeEmployee(string FirstName, string LastName, string Email) 
        : base(FirstName, LastName, Email)
    {

    }

    public void printSalary()
    {
        Console.WriteLine("Yearly Salary = $ {0}/=",this._yearlySalary);
    }
}
class PartTimeEmployee:Employee
{    
    public float _hourlySalary;

    public PartTimeEmployee(string FirstName, string LastName, string Email) 
        : base(FirstName, LastName, Email)
    {
    }

    public void printSalary()
    {
        Console.WriteLine("Hourly Salary = $ {0}/=", this._hourlySalary);
    }
}


internal class Program
{
    static void Main()
    {
        FullTimeEmployee fte1 = new FullTimeEmployee("Ali", "Raza","aliRaza@gmail.com");
        fte1.printFullName();
        fte1.printEmailAddress();
        fte1._yearlySalary = 120000;
        fte1.printSalary();

        PartTimeEmployee pte1 = new PartTimeEmployee("Salman", "Shakeel","salmanShakeel@gmail.com");
        pte1.printFullName();
        pte1.printEmailAddress();
        pte1._hourlySalary = 60.28F;
        pte1.printSalary(); 

    }
}

