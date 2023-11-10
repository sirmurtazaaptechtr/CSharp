using System;
using System.Collections.Generic;

namespace May082023_1
{
    delegate bool IsPromotable(employee emp);
    internal class Program
    {
        static void Main()
        {          

            List<employee> employeelist = new List<employee>();
            employeelist.Add(new employee() { ID = 1, Name = "Hamza", Experience = 1, Salary = 4000 });
            employeelist.Add(new employee() { ID = 2, Name = "Uzair", Experience = 5, Salary = 2000 });
            employeelist.Add(new employee() { ID = 3, Name = "Nimra", Experience = 5, Salary = 5000 });
            employeelist.Add(new employee() { ID = 4, Name = "Haleema", Experience = 7, Salary = 4500 });
            employeelist.Add(new employee() { ID = 5, Name = "Ruhaifa", Experience = 10, Salary = 3500 });
            employeelist.Add(new employee() { ID = 6, Name = "Habib", Experience = 6, Salary = 1500 });
            employeelist.Add(new employee() { ID = 7, Name = "Zaki", Experience = 3, Salary = 7500 });
            employeelist.Add(new employee() { ID = 8, Name = "Zain", Experience = 4, Salary = 8500 });
            employeelist.Add(new employee() { ID = 9, Name = "Faizan", Experience = 20, Salary = 13500 });
            employeelist.Add(new employee() { ID = 10, Name = "Huzaifa", Experience = 2, Salary = 4500 });
            employeelist.Add(new employee() { ID = 11, Name = "Fahad", Experience = 12, Salary = 14500 });
            
            IsPromotable isPromotable = new IsPromotable(Promote);
            employee.PormoteEmployee(employeelist,isPromotable);

            
        }
        public static bool Promote(employee emp)
        {
            if(emp.Experience >= 5)
            {
                return true;
            }
            else
            { 
                return false;
            }   
        }

    }    
    class employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PormoteEmployee(List<employee> employees,IsPromotable isEligibleToPromote)
        {
            foreach (employee emp in employees)
            {
                if (isEligibleToPromote(emp))
                {
                    Console.WriteLine(emp.Name + " is Promoted");
                }
            }

        }
    }    
}
