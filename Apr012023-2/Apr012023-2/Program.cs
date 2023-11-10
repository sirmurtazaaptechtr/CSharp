using System;
using System.Collections.Generic;

namespace Apr012023_2
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employees)
        {
            foreach(Employee employee in employees) 
            {
                if(employee.Experience >= 5)
                {
                    Console.WriteLine(employee.Name+" is Promoted.");
                }
            }
        }

    }
    internal class Program
    {
        static void Main()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { Id = 100, Name = "Sardar Uzair", Salary = 10000, Experience = 4});
            emplist.Add(new Employee() { Id = 101, Name = "Zaki", Salary = 12000, Experience = 8});
            emplist.Add(new Employee() { Id = 102, Name = "Habib", Salary = 15000, Experience = 9});
            emplist.Add(new Employee() { Id = 103, Name = "Hamza", Salary = 14000, Experience = 4});

            Employee.PromoteEmployee(emplist);

        }
    }
}
