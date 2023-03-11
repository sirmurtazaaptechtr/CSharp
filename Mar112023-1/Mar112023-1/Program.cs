using System;
namespace Mar112023_1
{
    internal class Program
    {
        static void Main()
        {
            int sum;
            Program.Add(2, 3);
            Program.Add(2.5f, 3.7f);
            Program.Add(2, 3, 4);
            Program.Add(2, 4, out sum);
        }
        public static void Add(int FN, int SN)
        {
            Console.WriteLine("1:Sum = {0}", FN + SN);
        }
        public static void Add(float FN, float SN)
        {
            Console.WriteLine("2:Sum = {0}", FN + SN);
        }
        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine("3:Sum = {0}", FN + SN + TN);
        }
        public static void Add(int FN, int SN, out int Sum)
        {
            Console.WriteLine("4:Sum = {0}", FN + SN);
            Sum = FN + SN;
        }
        //public static int Add(int FN, int SN)
        //{
        // we cant overload methods on the basis of return type
        // as they are not the part of signature
        //}
    }
}