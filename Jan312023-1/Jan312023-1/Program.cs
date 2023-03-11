using System;


namespace Jan312023_1
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("C# is Working...");

            int num1 = 11;
            int num2 = 5;
            float num3 = 3.14f;

            Console.WriteLine(num1+num2+num3);
            Console.WriteLine((float)num1/num2);

            int i = 100;
            float f = i;            
            Console.WriteLine("i={0} and f={1}",i,f);

            f = 3.14f;
            i = (int)f;
            Console.WriteLine("i={0} and f={1}",i,f);

            f = 22.7f;
            i = Convert.ToInt32(f);
            Console.WriteLine("i={0} and f={1}",i,f);

            f = 922337203685477580.7f;
            //i = (int)f;
            Console.WriteLine(Int64.MaxValue);           

            Int64 num4 = Convert.ToInt64(f);
            Console.WriteLine("num4={0} and f={1}", num4, f);

            string str = "1024";
            int num = 0;
            //num = int.Parse(str);           

            if (int.TryParse(str, out num))
            {
                Console.WriteLine("Conversion Successful!");
            }
            else
            {
                Console.WriteLine("Conversion Failed!\n{0} is not a number", str);
            }
            Console.WriteLine("str={0} and num={1}",str,num);
        }
    }
}