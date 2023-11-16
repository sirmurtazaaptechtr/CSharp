using System;

namespace Nov152023
{
    internal class Program
    {
        static void Main()
        {
            //string username, password;

            //TakeInput:
            //Console.Write("Username : ");
            //username = Console.ReadLine();
            //Console.Write("Password : ");
            //password = Console.ReadLine();

            //if(username == "admin" && password == "admin@123")
            //{
            //    Console.WriteLine("\nWelcome to My Application\n");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect Username or Password");
            //    goto TakeInput;
            //}

            int num1, num2, op;
            INPUTALL:
            Console.Write("Enter First Number : ");
            bool isNum1Converted = int.TryParse(Console.ReadLine(), out num1);
            Console.Write("Enter Second Number : ");
            bool isNum2Converted = int.TryParse(Console.ReadLine(), out num2);
            if(isNum1Converted && isNum2Converted) 
            {
                INPUTOP:
                Console.Write("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\nEnter Your Choice (1-4) : ");
                bool isOpConverted = int.TryParse(Console.ReadLine(), out op);
                if(isOpConverted) 
                {
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
                        break;
                        case 2:
                            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
                        break;
                        case 3:
                            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
                        break;
                        case 4:
                            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
                        break;
                        default:
                            Console.WriteLine("Invalid Input!");
                            goto INPUTOP;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Option Type");
                    goto INPUTOP;
                }
            }
            else
            {
                Console.WriteLine("\nInvalid Type! Try Again\n");
                goto INPUTALL;
            }
        }
    }
}