using System;
namespace Feb162023_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter First Number :");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number :");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("x={0}, y={1}", x, y);

            Program.twoOutput(ref x, ref y);

            Console.WriteLine("x={0}, y={1}", x, y);

            int sum, avg;
            sum = avg = 0;

            Program.twoFun(x, y,out sum,out avg);

            Console.WriteLine("sum={0}, avg={1}",sum,avg);

            Program.moreFun(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Program.moreFun(10, 20, 30);

        }
        public static void twoOutput (ref int x, ref int y)
        {
            x++;
            y++;
        }
        public static void twoFun(int x, int y, out int sum, out int avg)
        {
            sum = x + y;
            avg = sum / 2;
        }
        public static void moreFun(params int[] numbers)
        {
            Console.WriteLine("We have {0} elements",numbers.Length);

            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}