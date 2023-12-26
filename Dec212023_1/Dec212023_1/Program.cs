using System;
using System.Runtime.InteropServices;

namespace Dec212023_1
{
    internal class Program
    {
        static void Main()
        {
            int num1, num2;
            

            try
            {
                Console.Write("Enter First Number : ");
                int.TryParse(Console.ReadLine(), out num1);
            
                Console.Write("Enter Second Number : ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Second Number can't be zero");
                
            }
            finally
            {
                Console.WriteLine("The End");
            }

        }
    }
}
