using System;

namespace Apr272024
{
    class FullTimeEmployee : Employee
    {
        public float MonthlySalary {  get; set; }

        public new void Print()
        {
            //base.Print();
            Console.WriteLine($"Employee ID : {EmpId}\nFull Name : {FirstName} {LastName}\nEmail : {Email}\nSalary/Month : PKR {MonthlySalary}/= ");
        }
    }
}
