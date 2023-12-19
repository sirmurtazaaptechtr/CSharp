using System;

namespace Dec182023_2
{
    internal class Program
    {
        public static void takeInput(ref int a, ref int b)
        {
            Console.Write("Enter First number : ");
            int.TryParse(Console.ReadLine(), out a);
        
            Console.Write("Enter Second number : ");
            int.TryParse(Console.ReadLine(), out b);
        }
        public static void showResult (int a, int b)
        {
            Console.WriteLine(a + " / " + b + " = " + a / b);
        }
        static void Main()
        {

            int num1 = 0, num2 = 0;
            
            try
            {
                takeInput(ref num1, ref num2);
                showResult(num1, num2);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Second Number should be greater than 0");
                takeInput(ref num1, ref num2);
                showResult(num1, num2);
            }
            finally
            {
                Console.WriteLine("The End");
            }
        }
    }
}
