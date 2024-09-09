using System;

namespace Sep092024
{
    internal class Program
    {
        static void Main()
        {
            //Console.Write("Enter Any Number: ");
            //int num = int.Parse(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine($"{num} is Even");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is Odd");
            //}
            //float maxmarks = 75f;

            //Console.Write($"Enter Marks out of {maxmarks}: ");
            //float obtmarks = float.Parse(Console.ReadLine());

            //double percentage = Math.Round(obtmarks / maxmarks * 100, 2);

            //Console.WriteLine($"Marks = {obtmarks}/{maxmarks}\nPercentage = {percentage}%");

            //if (percentage < 40.0)
            //{
            //    Console.WriteLine("Status = FAIL");
            //}
            //else
            //{
            //    Console.WriteLine("Status = PASS");
            //}

            //if (percentage >= 80.0)
            //{
            //    Console.WriteLine("Grade = A+");
            //}
            //else if (percentage >= 70.0)
            //{
            //    Console.WriteLine("Grade = A");
            //}
            //else if (percentage >= 60.0)
            //{
            //    Console.WriteLine("Grade = B");
            //}
            //else if (percentage >= 50.0)
            //{
            //    Console.WriteLine("Grade = C");
            //}
            //else if (percentage >= 40.0)
            //{
            //    Console.WriteLine("Grade = D");
            //}
            //else
            //{
            //    Console.WriteLine("Grade = No-Grade");
            //}
            //bool flag = true;
            //do
            //{

            //    Console.Write("Enter First Number: ");
            //    float firstnum = float.Parse(Console.ReadLine());
            //    Console.Write("Enter Second Number: ");
            //    float secondnum = float.Parse(Console.ReadLine());

            //    Console.Write("1.ADD\n2.SUB\n3.MUL\n4.DIV\nEnter Your Choice (1-4): ");
            //    int choice = int.Parse(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine($"{firstnum} + {secondnum} = {firstnum + secondnum}");
            //            break;
            //        case 2:
            //            Console.WriteLine($"{firstnum} - {secondnum} = {firstnum - secondnum}");
            //            break;
            //        case 3:
            //            Console.WriteLine($"{firstnum} X {secondnum} = {firstnum * secondnum}");
            //            break;
            //        case 4:
            //            Console.WriteLine($"{firstnum} / {secondnum} = {firstnum / secondnum}");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Choice!");
            //            break;
            //    }

            //    Console.Write("Do you want to perform another calculation (Y/N):");
            //    string answer = Console.ReadLine();
            //    if (answer == "Y" || answer == "y")
            //    {
            //        flag = true;
            //    }
            //    else
            //    {
            //        flag = false;
            //    }
            //} while (flag);

            string[] names = {"Khurram", "Uzair", "Javeria", "Sadaf" };

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);

            //for (int i = 0; i < names.Length; i++) 
            //{
            //    Console.WriteLine($"{i+1}. {names[i]}");
            //}
            int srno = 1;
            foreach (string name in names) 
            {
                Console.WriteLine($"{srno}. {name}");
                srno++;
            }

        }
    }
}