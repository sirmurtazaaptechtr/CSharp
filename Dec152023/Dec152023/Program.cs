using System;
using System.Collections.Generic;

namespace Dec152023
{
    public delegate bool IsPromoted(Employee emp);
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeelist, IsPromoted isPro)
        {
            foreach (Employee employee in employeelist)
            {
                if (isPro(employee))
                {
                    Console.WriteLine(employee.Name + " is Promoted");
                }
            }
        }
    }
    //public delegate void MyDelegate(string str);
    internal class Program
    {
        public static bool CheckPromotion (Employee employee)
        {
            if(employee.Experience > 2 && employee.Salary > 1000)
            {
                return true;
            }else
            {
                return false;

            }
        }
        static void Main()
        {
            //MyDelegate md = new MyDelegate(Print);
            //md("Saqlain Dejwani");

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id=1, Name="Kinza Danish", Salary=1230.45f, Experience=4});
            employees.Add(new Employee() { Id=2, Name="Ahsan Khan", Salary=2230.50f, Experience=2});
            employees.Add(new Employee() { Id=3, Name="Rohaan Hussain", Salary=5230.40f, Experience=6});
            employees.Add(new Employee() { Id=4, Name="Shayan Ahmed", Salary=230.75f, Experience=1});
            employees.Add(new Employee() { Id=5, Name="Saqlain Dejwani", Salary=7230.80f, Experience=12});

            IsPromoted ip = new IsPromoted(CheckPromotion);
            Employee.PromoteEmployee(employees,ip);
        }

        //public static void Print (string message)
        //{
        //    Console.WriteLine("Hello " + message);
        //}
    }
    
}
