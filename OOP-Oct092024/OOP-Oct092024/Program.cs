using System;

namespace OOP_Oct092024
{
    class Employee
    {
        private string name; // field
        private int id; // field
                             
        //public string Name { get; set; }
        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
        
        public int Id { 
            get
            { 
                return this.id;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("id can't be less than 1");
                    this.id = 0;
                }
                else
                {
                    this.id = value;
                }
            }
        }
        public string Gender { get; set;}
        public void PersonalInfo ()
        {
            Console.WriteLine($"Employee ID : {this.Id}\nName : {this.Name}\nGender : {this.Gender}");
        }
    }
    class FullTimeEmployee : Employee 
    {
        public float MonthlySalary {  get; set;}

        public void ShowBio()
        {
            Console.WriteLine($"Employee ID : {this.Id}\nName : {this.Name}\nGender : {this.Gender}\nAnnual Salary : {this.MonthlySalary * 12} ");
        }

        public new void PersonalInfo ()
        {
            Console.WriteLine("New Child Method");
        }
    }
    class PartTimeEmployee : Employee 
    {
        public float HourlyRate {  get; set;}
        public void ShowBio()
        {
            Console.WriteLine($"Employee ID : {this.Id}\nName : {this.Name}\nGender : {this.Gender}\nAnnual Salary : {this.HourlyRate * 8 * 30 * 12} ");
        }
    }
    internal class Program
    {
        static void Main()
        {
            PartTimeEmployee emp1 = new PartTimeEmployee();
            emp1.Name = "Test";
            emp1.Gender = "Female";
            emp1.Id = 1;
            emp1.HourlyRate = 425.50f;
            emp1.ShowBio();
            
            FullTimeEmployee emp2 = new FullTimeEmployee();
            emp2.Name = "Test2";
            emp2.Gender = "Male";
            emp2.Id = 2;
            emp2.MonthlySalary = 95000;
            emp2.ShowBio();
            emp2.PersonalInfo();
            ((Employee)emp2).PersonalInfo();
        }
    }
}
