using System;
class Employee
{
    //string _firstName = "Ali";
    //string _lastName = "Raza";
    string _firstName;
    string _lastName;

    public Employee()
        : this(" - ", " - ")
    {

    }
    public Employee(string FirstName,string LastName)
    {
        _firstName = FirstName;
        _lastName = LastName;
    }
    public void PrintFullName()
    {
        Console.WriteLine("Full Name is {0} {1}", this._firstName, this._lastName);
    }
}
internal class Program
{
    static void Main()
    {
        Employee emp1 = new Employee("Moiz","Ghazali");       
        emp1.PrintFullName();

        Employee emp2 = new Employee();
        emp2.PrintFullName();

        Console.Read();

    }
}

