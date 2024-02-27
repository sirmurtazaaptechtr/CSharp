using System;

namespace Feb272024
{
    internal class Program
    {
        static void Main()
        {
            // Builtin Datatypes 
            bool isValid = false;
            int number = 227;
            float realnumber = 22.7f;

            Console.WriteLine("isValid = {0}\nnumber = {1}\nrealnumber = {2}",isValid,number,realnumber);

            Console.Write("Enter first Number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second Number : ");
            int num2 = int.Parse(Console.ReadLine());
            int res = num1 + num2;

            Console.WriteLine("{0} + {1} = {2}",num1,num2,res);

            // Message for input.
            Console.Write("Enter Your First Name : ");
            // Read user input and store it.
            string FirstName = Console.ReadLine();

            Console.Write("Enter Your Last Name : ");
            string LastName = Console.ReadLine();

            Console.WriteLine("Dear "+FirstName+" "+LastName+", How are you?");// Concatenation Method.
            Console.WriteLine("Dear {0} {1}, How are you?",FirstName,LastName);// Placeholder Method.

            //Console.WriteLine("Hi there.");
            //MyFun();
            //Program p = new Program();
            //p.TheFun();
        }

        static void MyFun ()
        {
            Console.WriteLine("This is My Function.");
        }

        void TheFun () 
        {
            Console.WriteLine("This is The Function.");
        }
    }
}
