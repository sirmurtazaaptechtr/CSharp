using System;
using System.Security.Permissions;

namespace Nov202023
{
    internal class Program
    {
        static void Main()
        {
            string[] students = new string[6];
            students[0] = "Ahsan";
            students[1] = "Kinza";
            students[2] = "Yaseen";
            students[3] = "Rohan";
            students[4] = "Saqlain";
            students[5] = "Saqlain";
            //for(int i = 0; i < students.Length; i++) 
            //{
            //    Console.WriteLine("Hi " + students[i]);
            //}
            foreach (string student in students)
            {
                Console.WriteLine("Hi " + student);
            }
            Program pro = new Program();

            Console.WriteLine("Even Numbers between 1 and 10");
            pro.EvenNumbers(1, 10);

            Console.WriteLine("Even Numbers between 5 and 15");
            pro.EvenNumbers(5, 15);

            int sq = Program.Squrer(12);

            Console.WriteLine("The square of 12 is {0}", sq);

            Console.WriteLine("The square of 5 is {0}", Program.Squrer(5));

        }

        public void EvenNumbers(int start_num,int end_num)
        {
            for(int i = start_num; i <= end_num; i++)            
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static int Squrer (int number)
        {
            return number * number;
        }
    }
}