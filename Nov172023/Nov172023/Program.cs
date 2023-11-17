using System;
namespace Nov172023
{
    internal class Program
    {
        static void Main()
        {
            //for (int cnt = 1; cnt <= 3; cnt++)
            //{
            //    Console.WriteLine(cnt);
            //}

            //int cnt = 1;
            //while (cnt <= 3)
            //{
            //    Console.WriteLine(cnt);
            //    cnt++;
            //}            

            //int cnt = 1;
            //do
            //{
            //    Console.WriteLine(cnt);
            //    cnt++;
            //}
            //while (cnt <= 3);

            //int tab, cnt;
            //Console.Write("Enter Table Number : ");
            //bool isConverted = int.TryParse(Console.ReadLine(), out tab);

            //if(isConverted)
            //{
            //    cnt = 1;
            //    while (cnt <= 10)
            //    {
            //        Console.WriteLine("{0} x {1} = {2}", tab, cnt, tab * cnt);
            //        cnt++;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input!");
            //}

            int number;
            bool isPrime = true;
            Console.Write("Enter any number : ");
            bool isConverted = int.TryParse(Console.ReadLine(),out number);
            if(isConverted)
            {
                for(int i = 2; i < number; i++)
                {
                    if(number%i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

            }
            if(isPrime)
            {
                Console.WriteLine("{0} is PRIME",number);
            }
            else
            {
                Console.WriteLine("{0} is not PRIME", number);
            }

            int fnum, snum;
            bool isPrimeNumber = true;

            Console.Write("Enter First Number : ");
            bool isFNConverted = int.TryParse(Console.ReadLine(), out fnum);

            Console.Write("Enter Second Number : ");
            bool isSNConverted = int.TryParse(Console.ReadLine(), out snum);

            if(isFNConverted && isSNConverted)
            {
                for(int num = fnum; num <= snum;  num++)
                {
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrimeNumber = false;
                            break;
                        }
                    }
                    if(isPrimeNumber)
                    {
                        Console.WriteLine(num);
                    }
                    isPrimeNumber = true;
                }
            }
        }
    }
}
