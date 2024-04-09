using System;

namespace Apr092024_1
{
    class Employee
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Employee(int id)
        {
            Id = id;
        }
    }

    class MonthlyEmployee : Employee
    {
        public float MonthlySalary { get; set; }

        public MonthlyEmployee(int id) : base(id)
        {
        }

        public float CalculateWeeklySalary()
        {
            return MonthlySalary / 30 * 7;
        }

        public override string ToString()
        {
            return $"ID : {Id}\nName : {Name}\nEmail : {Email}\nPhone : {Phone}\nWeeklySalary : {CalculateWeeklySalary()}";
        }
    }

    class ParttimeEmployee : Employee
    {
        public float HourlyRate { get; set; }

        public ParttimeEmployee(int id) : base(id)
        {
        }

        public float CalculateWeeklySalary()
        {
            return HourlyRate * 8 * 7;
        }

        public override string ToString()
        {
            return $"ID : {Id}\nName : {Name}\nEmail : {Email}\nPhone : {Phone}\nWeeklySalary : {CalculateWeeklySalary()}";
        }
    }

    internal class Program
    {
        static void Main()
        {
            ParttimeEmployee pte1 = new ParttimeEmployee(1);
            pte1.Name = "Ali";
            pte1.Email = "Ali@gmail.com";
            pte1.Phone = "03121220006";
            pte1.HourlyRate = 1250.00f;

            MonthlyEmployee me1 = new MonthlyEmployee(2);
            me1.Name = "Hassan";
            me1.Email = "hassan@gmail.com";
            me1.Phone = "03333223231";
            me1.MonthlySalary = 125000.00f;

            Console.WriteLine(pte1);
            Console.WriteLine(me1);
        }
    }
}
