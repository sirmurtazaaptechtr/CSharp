using System;

namespace Nov142023
{
    internal class Program
    {
        static void Main()
        {
            int i = 15;
            float f = i;
            Console.WriteLine(f);

            //i = (int)f;
            i = Convert.ToInt32(f);
            Console.WriteLine(i);

            TakeInput:
            Console.Write("Enter your age : ");
            int age;
            //age = int.Parse(Console.ReadLine());
            //Console.WriteLine(age);

            bool isConverted = int.TryParse(Console.ReadLine(), out age);
            if(isConverted) 
            {
                Console.WriteLine(age);
            }
            else
            {
                Console.WriteLine("Invalid Input!\nTry Again");
                goto TakeInput;
            }

            int[] ages = new int[5];
            ages[0] = 20;
            ages[1] = 16;
            ages[2] = 17;
            ages[3] = 22;
            ages[4] = 21;

            Console.WriteLine(ages[3]);
            //Single line comment 
            /* Multi
             * Line 
             * Comment
             */
        }
    }
}