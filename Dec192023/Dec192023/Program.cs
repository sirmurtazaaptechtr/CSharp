using System;
using System.Collections.Generic;

namespace Dec192023
{
    //public delegate void MyDel(string str1, string str2);
    delegate bool IsPromoteable(Employee employee);

    class Employee
    {
        public int ID { get; set; }
        public string Name  { get; set; }
        public float Salary  { get; set; }
        public int Experience  { get; set; }

        public void PromoteEmployees (List<Employee> employees,IsPromoteable ip)
        {
            foreach (Employee employee in employees) 
            {
                if (ip(employee))
                {
                    Console.WriteLine("{0} is Promoted", employee.Name);
                }
            }

        }
    }  

    internal class Program
    {
        public static bool Promote(Employee employee)
        {
            if (employee.Experience > 1 && employee.Salary > 2000) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        static void Main()
        {
            List<Employee> employeeslist = new List<Employee>();
            employeeslist.Add(new Employee { ID = 1, Name = "Rabia Asif", Experience = 4, Salary = 4500 });
            employeeslist.Add(new Employee { ID = 2, Name = "Sakina Qasim", Experience = 2, Salary = 1500 });
            employeeslist.Add(new Employee { ID = 3, Name = "Saad Khurram", Experience = 6, Salary = 6500 });
            employeeslist.Add(new Employee { ID = 4, Name = "Zubair Khan", Experience = 1, Salary = 1000 });
            employeeslist.Add(new Employee { ID = 5, Name = "Taha Tehseen", Experience = 11, Salary = 11750 });

            IsPromoteable ispro = new IsPromoteable(Promote);

            Employee emp = new Employee();
            emp.PromoteEmployees(employeeslist,ispro);

            //MyDel md = new MyDel(Print);
            //md("Hello how do you do","Murtaza");
        }
        //public static void Print(string message, string sender) 
        //{
        //    Console.WriteLine(sender + " says, " + message);
        //}
    }
}
