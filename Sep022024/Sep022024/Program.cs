using System;

namespace Sep022024
{
    internal class Program
    {
        static void Main()
        {
            float maxmarks, obtmarks, percentage;
            maxmarks = 75f;

            Console.Write("Enter Obtained Marks : ");
            obtmarks = float.Parse(Console.ReadLine());

            percentage = (float)Math.Round(obtmarks / maxmarks * 100,2);

            Console.WriteLine($"Max Marks : {maxmarks}\nObt. Marks : {obtmarks}\nPercentage : {percentage}%");
            // for status
            if(percentage < 40)
            {
                Console.WriteLine("Status : Fail");
            }                      
            else                   
            {                      
                Console.WriteLine("Status : Pass");
            }
            // for grade
            if(percentage >= 80)
            {
                Console.WriteLine("Grade : A+");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Grade : A");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Grade : B");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Grade : C");
            }
            else if (percentage >= 40)
            {
                Console.WriteLine("Grade : D");
            }
            else
            {
                Console.WriteLine("Grade : No-Grade");
            }
        }
    }
}
