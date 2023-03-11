using System;

namespace Jun092022_1
{
    internal class Program
    {
        static void Main()
        {
            int num1 = 20,num2 = 10,res;

            res = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}",num1,num2,res);
            res = num1 - num2;
            Console.WriteLine("{0} - {1} = {2}",num1,num2,res);
            res = num1 * num2;
            Console.WriteLine("{0} X {1} = {2}",num1,num2,res);
            res = num1 / num2;
            Console.WriteLine("{0} / {1} = {2}",num1,num2,res);
            res = num1 % num2;
            Console.WriteLine("MOD({0},{1}) = {2}",num1,num2,res);
            
            string UserName = "web",uid;
            Console.Write("Enter User ID : ");
            uid = Console.ReadLine();

            bool isIDMatched = UserName == uid;

            Console.WriteLine("ID matched = {0}", isIDMatched);

            Console.Write("Enter age : ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Do you have a Driving License?(Yes/No) : ");
            string dl = Console.ReadLine();

            //bool isAdult = age >= 18;
            //Console.WriteLine("Adult = {0}",isAdult);

            if (age >= 18 && dl == "Yes")
            {
                Console.WriteLine("You can Drive");
            }
            else
            {
                int AgeDiff = 18 - age;
                Console.WriteLine("Get DL after {0} years",AgeDiff);
            }



        }        
    }
}
