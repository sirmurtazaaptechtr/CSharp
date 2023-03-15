using System;
namespace Mar152023_1
{
    public struct Employee
    {
        public int Id { get ; set ; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Print()
        {
            System.Console.WriteLine("ID : {0}\nName : {1}",Id,Name);
        }       
    }
    public class Customer
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; }

        public Customer()
        {
            
        }
        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void Print()
        {
            System.Console.WriteLine("ID : {0}\nName : {1}", Id, Name);
        }
        ~Customer()
        {
            System.Console.WriteLine("The End");
        }
    }
    
    internal class Program
    {
        static void Main()
        {
            Employee emp1 = new Employee(1,"Habib ur Rehman");
            emp1.Print();

            Employee emp2 = new Employee();
            emp2.Id = 2;
            emp2.Name = "Uzair Khan";
            emp2.Print();

            Employee emp3 = new Employee
            {
                Id= 3,
                Name="Zaki Usman"
            };
            emp3.Print();

            int i = 10;
            int j = i;

            Console.WriteLine("i:{0},j:{1}",i,j);
            j = 15;
            Console.WriteLine("i:{0},j:{1}",i,j);

            Customer c1 = new Customer(1, "Ali");
            Customer c2 = new Customer();

            c2 = c1;
            c2.Print();

            c2.Name = "Hamza Malik";

            c1.Print();
            
        }
    }
}
