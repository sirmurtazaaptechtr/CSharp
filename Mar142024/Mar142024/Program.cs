using System;

namespace Mar142024
{
    internal class Program
    {
        static void Main()
        {
            int num = 10;
            while(num < 10)
            {
                Console.WriteLine($"{num} is less than 10");
                num ++;
            }
            Console.WriteLine($"num = {num}");


            num = 10;
            do
            {
                Console.WriteLine($"{num} is less than 10");
                num++;
            }
            while (num < 10);
            Console.WriteLine($"num = {num}");

            int st, ed, cnt;
            Console.Write("Enter Start : ");
            st = int.Parse(Console.ReadLine());
            Console.Write("Enter End : ");
            ed = int.Parse(Console.ReadLine());
            cnt = st;

            if(cnt < ed)
            {                
                while (cnt <= ed) 
                {
                    Console.WriteLine(cnt);
                    cnt++;
                }
            }
            else
            {             
                while (cnt >= ed)
                {
                    Console.WriteLine(cnt);
                    cnt--;
                }

            }

        }
    }
}
