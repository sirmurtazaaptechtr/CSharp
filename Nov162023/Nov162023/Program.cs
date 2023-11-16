using System;
namespace Nov162023
{
    internal class Program
    {
        static void Main()
        {
            //    float ObtMarks;
            //    float MaxMarks = 75;
            //INPUT:
            //    Console.Write("Enter Obtained Marks : ");            
            //    bool isConverted = float.TryParse(Console.ReadLine(), out ObtMarks);
            //    if (isConverted && ObtMarks >= 0 && ObtMarks <= 75)
            //    {
            //        float percentage = ObtMarks / MaxMarks * 100;
            //        if(percentage >= 40)
            //        {
            //            Console.WriteLine("Percentage = {0}%\nStatus = PASS", percentage);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Percentage = {0}%\nStatus = FAIL", percentage);

            //        }
            //        if(percentage >= 80) 
            //        {
            //            Console.WriteLine("Grade = A+");
            //        }
            //        else if (percentage >= 70)
            //        {
            //            Console.WriteLine("Grade = A");
            //        }
            //        else if (percentage >= 60)
            //        {
            //            Console.WriteLine("Grade = B");
            //        }
            //        else if (percentage >= 50)
            //        {
            //            Console.WriteLine("Grade = C");
            //        }
            //        else if (percentage >= 40)
            //        {
            //            Console.WriteLine("Grade = D");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Grade = F");
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Obtained marks must be a real number between 0 - 75");
            //        goto INPUT;
            //    }

            //int Num1, Num2, Op;
            //Console.Write("Enter First Number : ");
            //bool isConvertedNum1 = int.TryParse(Console.ReadLine(), out Num1);
            //Console.Write("Enter Second Number : ");
            //bool isConvertedNum2 = int.TryParse(Console.ReadLine(),out Num2);
            //Console.Write("1. ADD\n2. SUB\n3. MUL\n4. DIV\nEnter Option : ");
            //bool isConvertedOp = int.TryParse(Console.ReadLine(), out Op);
            //if (isConvertedNum1 && isConvertedNum2 && isConvertedOp)            
            //{
            //    switch (Op)
            //    {
            //        case 1:
            //            Console.WriteLine("{0} + {1} = {2}", Num1, Num2, Num1 + Num2);
            //            break;
            //        case 2:
            //            Console.WriteLine("{0} - {1} = {2}", Num1, Num2, Num1 - Num2);
            //            break;
            //        case 3:
            //            Console.WriteLine("{0} x {1} = {2}", Num1, Num2, Num1 * Num2);
            //            break;
            //        case 4:
            //            Console.WriteLine("{0} / {1} = {2}", Num1, Num2, (float)Num1 / Num2);
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Choice!");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input!");
            //}

            int tab;
            Console.Write("Enter Table Number : ");
            bool isConverted = int.TryParse(Console.ReadLine(), out tab);
            if (isConverted)
            {
                //int cnt = 1;
                //while (cnt <= 10)
                //{
                //    Console.WriteLine("{0} X {1} = {2}", tab, cnt, tab * cnt);
                //    cnt++;
                //}

                int cnt = 1;
                do
                {
                    Console.WriteLine("{0} X {1} = {2}", tab, cnt, tab * cnt);
                    cnt++;
                } 
                while(cnt <= 10);

                //for(int i = 1;i <= 10;i++)
                //{
                //    Console.WriteLine("{0} X {1} = {2}", tab, i, tab * i);
                //}
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}