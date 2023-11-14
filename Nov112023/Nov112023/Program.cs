using System;

namespace Nov112023
{
    internal class Program
    {
        static void Main()
        {
            // to make a non-nullable value type nullable put ? after ?
            int? dbage = null;
            
            // null coalescing operator
            int age = dbage ?? 0;
            Console.WriteLine(age);
            bool? isStudent = null;
            Console.WriteLine(isStudent);

            if(age == 0) 
            {
                Console.WriteLine("User has not answered the question.");
            }else if(age < 18 ) 
            {
                int diff = 18 - age;
                Console.WriteLine("Come after {0} years.",diff);
                Console.WriteLine("Come after " + diff + " years.");
            }else
            {
                Console.WriteLine("You are eligiable for the DL");
            }

            // ternary operator ?:

            int number = 161;

            //if(number % 2 == 0) 
            //{
            //    Console.WriteLine("{0} is Even", number);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is Odd", number);
            //}
            string ans = number % 2 == 0 ? number + " is Even" : number + " is Odd";
            Console.WriteLine(ans);
        }
    }
}
