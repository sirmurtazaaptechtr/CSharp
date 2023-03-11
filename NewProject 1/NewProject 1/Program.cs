using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int i = 15;
            int j = 11;
            Console.WriteLine(i+","+j);
            j = 25;            
            Console.WriteLine(i+","+j);
            Console.WriteLine("{0},{1}", i, j);


            string str = "\u0048\u0065\u006c\u006c\u006f";
            Console.Write("\t" + str + "!\n");
            Console.WriteLine("Ghazali\u0020 \"2003\" ");

            string name;
            Console.Write("Enter Your Name:");
            name = Console.ReadLine();
            Console.WriteLine("Hi {0}, How are you ?", name);

            string custName;
            double loanAmount;
            float interest = 0.09F;
            double interestAmount = 0;
            double totalAmount = 0;

            Console.Write("Enter Customer Name:");
            custName = Console.ReadLine();
            Console.Write("Enter Loan Amount:");
            loanAmount = Convert.ToDouble(Console.ReadLine());
            interestAmount = loanAmount * interest;
            totalAmount = loanAmount + interestAmount;
            Console.WriteLine("\n Customer Name : {0}", custName);
            Console.WriteLine("Loan Amount : ${0:#,###.#0} \nInterest Rate : {1:0#%} \nInterest Amount : ${2:#,###.#0}",loanAmount,interest,interestAmount);
            Console.WriteLine("Total Amount to be Paid : ${0:#,###.#0}", totalAmount);

            Console.Read();
        }
    }
}
