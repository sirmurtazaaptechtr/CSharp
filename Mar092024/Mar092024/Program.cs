using System;

namespace Mar092024
{
    internal class Program
    {
        static void Main()
        {
            int validAge = 18;
            Console.Write("Enter Your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age >= validAge) 
            {
                Console.WriteLine("You are Eligible to get a Driving License");
            }
            else
            {
                Console.WriteLine($"You will be Eligible after {validAge - age} years.");
            }

            double phy, che, mat, eng, urd, maxmarks = 125, obtmarks, percentage;
            Console.Write("Physics Marks : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Chemistry Marks : ");
            che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maths Marks : ");
            mat = Convert.ToInt32(Console.ReadLine());
            Console.Write("English Marks : ");
            eng = Convert.ToInt32(Console.ReadLine());
            Console.Write("Urdu Marks : ");
            urd = Convert.ToInt32(Console.ReadLine());

            obtmarks = phy + che + mat + eng + urd;

            percentage = Math.Round((obtmarks/maxmarks) * 100,2);

            Console.WriteLine($"Marks : {obtmarks}/{maxmarks}\nPercentage : {percentage}%");

            if(percentage < 40)
            {
                Console.WriteLine("Status : PASS");
            }
            else
            {
                Console.WriteLine("Status : FAIL");
            }


        }
    }
}
