using System;

namespace May082024
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter First Number : ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Second Number : ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double res = num1 / num2;

                Console.WriteLine($"{num1} / {num2} = {res}");
            }
            catch (Exception ex) 
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Something went wrong...");

                //Console.Write("Enter any Number : ");
                //int x = int.Parse(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("The End");
            }
        }
    }
}
