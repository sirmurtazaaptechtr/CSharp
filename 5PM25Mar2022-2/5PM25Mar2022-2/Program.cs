using System;
class Customer
{
    public string firstName;
    public string lastName;
    public int age;
    public Customer()
        :this("No First Name Provided","No Last Name P")
    {}
    public Customer(string FirstName, string LastName)
    {
        this.firstName = FirstName;
        this.lastName = LastName;
    }
    public Customer(string FirstName, string LastName,int Age)
    {
        this.firstName = FirstName;
        this.lastName = LastName;
        this.age = Age;
    }
    public void printFullName()
    {
        Console.WriteLine("Full Name = {0} {1}", firstName, lastName);
    }
    ~Customer()
    {
        //Cleanup code goes here
    }
}
internal class Program
{
    static void Main()
    {
        Customer c1 = new Customer("Ali", "Raza");
        c1.printFullName();

        Customer c2 = new Customer("Saleem", "Khan");
        c2.printFullName();

        Customer c3 = new Customer();
        c3.printFullName();

        Customer c4 = new Customer("Saleh", "Awan", 20);

        //c4.printFullName();
        Console.WriteLine("Dear {0} {1}, you are {2} years old",c4.firstName,c4.lastName, c4.age);
    }
}