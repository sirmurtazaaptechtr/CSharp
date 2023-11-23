using System;

namespace Nov232023
{
    internal class Program
    {
        static void Main()
        {
            int num1 = 15, num2 = 5;
            Program p1 = new Program();            

            Console.WriteLine("Outside BS: num1 = {0} and num2 = {1}", num1, num2);
            p1.Swap(num1, num2);
            Console.WriteLine("Outside BS: num1 = {0} and num2 = {1}", num1, num2);

            Console.WriteLine("Outside BS: num1 = {0} and num2 = {1}", num1, num2);            
            p1.TheSwap(ref num1, ref num2);
            Console.WriteLine("Outside BS: num1 = {0} and num2 = {1}", num1, num2);

            int res1, res2, sum;
            p1.Squarer(num1, num2, out res1, out res2, out sum);
            Console.WriteLine("The square of {0} is {1}", num1, res1);
            Console.WriteLine("The square of {0} is {1}", num2, res2);
            Console.WriteLine("The sum of {0} and {1} is {2}", res1, res2, sum);

            int result = p1.AddNumbers();
            Console.WriteLine(result);

            int s1;
            float s2;
            p1.Status(out s1, out s2, 21, 17, 16, 41);
            Console.WriteLine("Sum = {0}\nAverage = {1}", s1, s2);
        }
        public void Swap(int a, int b)
        {
            Console.WriteLine("Inside BS: a = {0} and b = {1}", a, b);
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Inside AS: a = {0} and b = {1}", a, b);
        }
        public void TheSwap(ref int a, ref int b)
        {
            Console.WriteLine("Inside BS: a = {0} and b = {1}", a, b);
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Inside AS: a = {0} and b = {1}", a, b);
        }

        public void Squarer(int a, int b, out int r1, out int r2, out int s)
        {
            r1 = a * a;
            r2 = b * b;
            s = r1 + r2;
        }
        public int AddNumbers (params int[] numbers)
        {
            int sum = 0; 
            foreach(int number in numbers)
            {
                sum+= number;
            }
            return sum;
        }
        public void Status(out int sum, out float avg, int x, params int[] numbers)
        {
            int count = 0;
            sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
                count++;
            }
            avg = (float)sum/count;            
        }

    }
}
