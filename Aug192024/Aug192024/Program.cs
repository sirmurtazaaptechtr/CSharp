using System;

namespace Aug192024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Constants

            const float pi = 22f/7;

            Console.WriteLine(pi);

            float num1, num2, res = 0;

            num1 = 1;
            num2 = 2;

            res = num1 / num2;

            Console.WriteLine(res);

            // C# Type Casting

            // In C#, there are two types of casting:

            // Implicit Casting(automatically) -converting a smaller type to a larger type size
            // char -> int -> long -> float -> double

            // Explicit Casting(manually) - converting a larger type to a smaller size type
            // double -> float -> long -> int -> char

            int myInt = 9;
            double myDouble = myInt;

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            float myFloat = 3.14f;
            //myInt = (int)myFloat; //  Cast Operator
            myInt = Convert.ToInt32(myFloat);//  Convert Class 
            

            Console.WriteLine(myFloat);
            Console.WriteLine(myInt);

            myInt = 10;
            myDouble = 5.25D;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        }
    }
}
