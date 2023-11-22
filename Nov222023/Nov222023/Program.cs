using System;
namespace Nov222023
{
    internal class Program
    {
        static void Main()
        {
            int a = 15, b = 20, sqa, sqb, sumab;
            Program.TheMethod(a, b, out sqa, out sqb, out sumab);
            Console.WriteLine("square of {0} is {2}, square of {1} is {3} and their sum is {4}", a, b, sqa, sqb, sumab);
            int x, y;
            int result = Program.AddNumbers(20, 21, out x, out y, 21, 20, 14);
            Console.WriteLine(result);
            Console.WriteLine("{0}, {1}", x, y);
        }
        public static void TheMethod(int num1, int num2, out int sqnum1, out int sqnum2, out int sum) 
        {
            sqnum1 = num1 * num1;
            sqnum2 = num2 * num2;
            sum = num1 + num2;
        }
        public static int AddNumbers(int fnum, int snum, out int a, out int b, params int[] numbers) 
        {
            a = fnum;
            b = snum;
            int sum = 0;
            foreach (int number in numbers) 
            {
                sum += number;
            }
            return sum;
        }
    }
}