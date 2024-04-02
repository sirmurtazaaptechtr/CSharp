using System;

namespace Apr012024
{
    internal class Program
    {
        static void Main()
        {
            for(int i = 1;i < 10 ;i++) 
            {
                if(i % 2 == 0)
                {
                    continue;
                    //break;
                }
                Console.WriteLine(i);
            }

            //int[] number = { 15, 20 };

            //int[] number;
            //number = new int[] { 15, 20 };

            int[] numbers;
            numbers = new int[5] { 15, 20, 45, 23, 11 };
            //--------------------------For loop--------------------------
            //for(int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //--------------------------While loop--------------------------
            //int i = 0;

            //while (i < numbers.Length) 
            //{
            //    Console.WriteLine(numbers[i]);
            //    i++;
            //}
            foreach (int number in numbers) 
            {
                Console.WriteLine(number);
            }
            
            
        }
    }
}
