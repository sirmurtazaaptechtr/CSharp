using System;

namespace Nov302023
{
    class Employee
    {
        public string FirstName = "Aptech";
        public string LastName = "Learning";

        public virtual void Print()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    class PartTimeEmployee :Employee 
    {
        public override void Print()
        {
            Console.WriteLine(FirstName + " " + LastName + " - PartTime");
        }

    }
    class FullTimeEmployee : Employee 
    {
        public override void Print()
        {
            Console.WriteLine(FirstName + " " + LastName + " - FullTime");
        }

    }
    class TemperoryEmployee : Employee
    {
        public override void Print()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Temperory");
        }

    }

    internal class Program
    {
        static void Main()
        {
            Employee[] emp = new Employee[4];
            emp[0] = new Employee();
            emp[1] = new FullTimeEmployee();
            emp[2] = new PartTimeEmployee();
            emp[3] = new TemperoryEmployee();

            foreach (Employee e in emp)
            {
                e.Print();
            }
        }
    }
}
