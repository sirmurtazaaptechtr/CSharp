using System;
using System.Runtime.InteropServices;

namespace Nov282023
{
    class Area
    {
        static float PI = 3.14f;
        float _r;

        public Area(float radius)
        {
            this._r = radius;
        }

        public void Print ()
        {
            Console.WriteLine ("Area of circle with radius {0} is {1}",this._r,2*PI*this._r*this._r);
        }
    }
    class Employee
    {
        protected string company = "Aptech Learning";
        public int id;
        public string name;
        public string gender;
        public int age;

        public void Print () 
        {
            Console.WriteLine ("\nID : {0}\nName : {1}\nGender : {2}\nAge : {3}\n",this.id,this.name,this.gender,this.age);
        }
    }
    class ContactualEmployee : Employee
    {
        public float salary;
        public new void Print()
        {
            Console.WriteLine("\nID : {0}\nName : {1}\nGender : {2}\nAge : {3}\nHourly Salary = {4}\n", this.id, this.name, this.gender, this.age, this.salary);
        }
    }
    class PermanentEmployee : Employee
    {
        public float salary;
        public new void Print()
        {
            //base.Print(); // Method 2
            Console.WriteLine(company);
            Console.WriteLine("\nID : {0}\nName : {1}\nGender : {2}\nAge : {3}\nMonthly Salary = {4}\n", this.id, this.name, this.gender, this.age, this.salary);
        }
    }
    internal class Program
    {
        static void Main()
        {
            Area a1 = new Area(0.25f);
            Area a2 = new Area(5);

            a1.Print ();
            a2.Print ();

            Employee emp1 = new Employee();       
            emp1.id = 1;
            emp1.name = "Khurram";
            emp1.gender = "male";
            emp1.age = 17;            
            emp1.Print ();

            ContactualEmployee cemp1 = new ContactualEmployee();
            cemp1.id = 2;
            cemp1.name = "Sakina";
            cemp1.gender = "female";
            cemp1.age = 20;
            cemp1.salary = 2412.25f;
            cemp1.Print();

            PermanentEmployee pemp1 = new PermanentEmployee();
            //Employee pemp1 = new PermanentEmployee(); //Method 3
            pemp1.id = 3;
            pemp1.name = "Taha";
            pemp1.gender = "male";
            pemp1.age = 19;
            pemp1.salary = 122412.25f;
            pemp1.Print();
            //((Employee)pemp1).Print(); // Method 1 To call parent Method
        }
    }
}
