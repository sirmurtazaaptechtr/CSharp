using System;
class Customer
{
    string firstName = "Ali";
    string lastName = "Raza";    
    public void AddNewCustomer(string FirstName, string LastName)
    {
        this.firstName = FirstName;
        this.lastName = LastName;
    }
    public void printFullName()
    {
        Console.WriteLine("Full Name = {0} {1}", firstName, lastName);
    }
}

internal class Program
{
    static void Main()
    {
        Customer C1 = new Customer();
        C1.printFullName();

        C1.AddNewCustomer("Saleem", "Khan");
        C1.printFullName();

    }
}
