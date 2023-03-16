using System;
namespace Mar162023_1
{
    interface IMyInterface
    {
        void myMethod();  
    }
    interface IEmployee
    {
        void DisplayEmp();
    }
    interface ICustomer : IMyInterface
    {
        string Name { get; }
        void Print();
    }
    public class Customer : ICustomer, IEmployee
    {
        public string Name { get; set; }
        public void Print()
        {
            Console.WriteLine("This is Implementation of Print Method of Interface");
        }
        void IEmployee.DisplayEmp()
        {
            throw new NotImplementedException();
        }
        void IMyInterface.myMethod()
        {
            throw new NotImplementedException();
        }        
    }
    internal class Program
    {
        static void Main()
        {
            Customer c1 = new Customer();
            c1.Name = "Sardar Uzair";

            ICustomer customer = new Customer();
            customer.Print();
            Console.WriteLine(c1.Name);

        }
    }
}