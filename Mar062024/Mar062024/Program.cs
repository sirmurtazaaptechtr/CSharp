using System;
using System.Globalization;

namespace Mar062024
{
    internal class Program
    {
        static void Main()
        {
            int myNum = 54;
            float myRealNum = 0.1234567890f;
            double myRealNum2 = 0.12345678901234567d;
            bool isThere = false;
            string fullName = "Muhammad Ali";
            char ch = 'a';
            
            Console.WriteLine("myNum = {0},\nmyRealNum = {1},\nmyRealNum2 = {2}, \nisThere = {3},\nfullName = {4},\nch = {5}", myNum, myRealNum, myRealNum2, isThere, fullName, ch);

            float f = myNum;
            int i = (int)myRealNum;
            i = Convert.ToInt32(myRealNum);

            Console.WriteLine(f);
            Console.WriteLine(i);

            //Console.Write("Enter Your Full Name : ");
            //string name = Console.ReadLine();
            //Console.Write("Enter Your Age : ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Hi {0}, you are {1} years old.", name, age);

            float num1 = 22.0f;
            float num2 = 7.0f;

            float pi = num1 / num2;

            Console.WriteLine("PI = {0}", Math.Round(pi, 2));

            Console.WriteLine("\"{0}\" has {1} characters in it.", fullName, fullName.Length);

            Console.WriteLine("{0}", fullName.ToLower());
            Console.WriteLine("{0}", fullName.ToUpper());

            string firstName = "Muhammad";
            string lastName = "Ali";
            //string fullname = firstName + " " + lastName;
            //string fullname = string.Concat(firstName, " ", lastName);
            string fullname = $"{firstName} {lastName}";
            Console.WriteLine(fullname);
        }
    }
}