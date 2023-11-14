using System;

namespace Nov132023
{
    internal class Program
    {
        static void Main()
        {
            int i = 10;
            //implicit conversion
            float f = i + 2.5F;
            Console.WriteLine(f);

            //explicit conversion using cast operator
            int j = (int)f;
            Console.WriteLine(j);

            //explicit conversion using Convert class
            int k = Convert.ToInt32(f);
            Console.WriteLine(k);

            f = 9876543210123.123F;
            Console.WriteLine(f);
            //k = Convert.ToInt32(f);
            //Console.WriteLine(k);

            string s = "100";
            i = int.Parse(s);
            Console.WriteLine(i);

            i = 0;
            //s = "100AC";
            s = "501";
            bool isConverted = int.TryParse(s,out i);
            if(isConverted)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("\"{0}\" is not a number",s);
                Console.WriteLine(i);
            }

            int[] ages = new int[4];

            ages[0] = 21;
            ages[1] = 14;
            ages[2] = 19;
            ages[3] = 19;
            /*
             * this is 
             * a multi line 
             * comment
            */
            Console.WriteLine("Ahsan you are {0} years old", ages[0]);
            Console.WriteLine("Yaseen you are {0} years old", ages[3]);

            int number = 0;
            Console.Write("Enter any number : ");
            isConverted = int.TryParse(Console.ReadLine(),out number);

            if(isConverted) 
            {
                if(number%2 == 0)
                {
                    Console.WriteLine("{0} is Even",number);
                }
                else
                {
                    Console.WriteLine("{0} is Odd",number);
                }
            }
            else
            {
                Console.WriteLine("Invalid Input!"); 
            }
        }
    }
}