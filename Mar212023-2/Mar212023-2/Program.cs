using System;
using System.Runtime.InteropServices;

namespace Mar212023_2
{
    interface I
    {      
        string Name { get; }
    }
    public abstract class ACustomer
    {
        protected int _i = 0;
        public int i { get; set; }
        public void Print()
        {
            Console.WriteLine("This is print method of ACustomer");
        }
        public abstract void Print(string s);
    }
    public class Customer : ACustomer
    {
        public override void Print(string s)
        {
            Console.WriteLine("Dear {0}, Welcome!",s);
        }
    }
    internal class Program
    {
        static void Main()
        {
            Customer customer = new Customer();
            customer.Print();
            customer.Print("Abdullah");
        }
    }
}
