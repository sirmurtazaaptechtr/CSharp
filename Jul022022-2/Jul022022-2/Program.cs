using System;
internal class Program
{
    static void Main()
    {
        Customer C1 = new Customer("Abdullah", "Khan");
        Customer C2 = new Customer("Huzaifa", "Ali");
        Customer C3 = new Customer();
        C1.PrintFullName();
        C2.PrintFullName();
        C1._age = 18;
        C1._gender = "Male";
        C1.PrintFullData();
        C3.PrintFullName();
       
    }
}
class Customer
{
    string _firstName;
    string _lastName;
    public string _gender;
    public int _age;

    public Customer()
        :this("no First Name is Provided", "no Last Name is Provided")
    {

    }
    public Customer(string FirstName, string LastName)
    {
        this._firstName = FirstName;
        this._lastName = LastName;
    }
    public void PrintFullName()
    {
        Console.WriteLine("Hi {0} {1}, How are you?",this._firstName,this._lastName);
    }
    public void PrintFullData()
    {
        Console.WriteLine("Full Name : {0} {1}\nGender : {2}\nAge : {3}", this._firstName, this._lastName, this._gender, this._age);
    }
    ~Customer() 
    {

    }
}