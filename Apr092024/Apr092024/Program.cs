using System;

namespace Apr092024
{
    class Employee
    {

        public int _id;
        public string _name;
        public string _email;
        public string _phone;

    }
    class MonthlyEmployee : Employee
    {
        public float _monthlysalary;

        public void Print()
        {
            Console.WriteLine($"ID : {this._id}\nName : {this._name}\nEmail : {this._email}\nPhone : {this._phone}\nWeeklySalary : {this._monthlysalary / 30 * 7}");
        }
    }

    class ParttimeEmployee : Employee
    {
        public float _hourlyrate;
        public void Print()
        {
            Console.WriteLine($"ID : {this._id}\nName : {this._name}\nEmail : {this._email}\nPhone : {this._phone}\nWeeklySalary : {this._hourlyrate * 8 * 7}");
        }

    }
    internal class Program
    {

        static void Main()
        {
            ParttimeEmployee pte1 = new ParttimeEmployee();
            pte1._id = 1;
            pte1._name = " Ali";
            pte1._email = " Ali@gmail.com";
            pte1._phone = "03121220006";
            pte1._hourlyrate = 1250.00f;

            MonthlyEmployee me1 = new MonthlyEmployee();
            me1._id = 2;
            me1._name = "hassan";
            me1._email = "hassan@gmail.com";
            me1._phone = "03333223231";
            me1._monthlysalary = 125000.00f;


            pte1.Print();
            me1.Print();
        }

    }
}