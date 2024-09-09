using System;

namespace Sep042024
{
    internal class Program
    {
        

        static void Main()
        {
            Console.Write("Enter Day Number 1-7 : ");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            //C# While Loop

            int i = 1;
            while (i <= 5) 
            {
                Console.WriteLine(i);
                i++;
            }

            Console.Write("Do you want to see the message 1:yes 0:no");

            while (int.Parse(Console.ReadLine()) != 0)
            {
                Console.WriteLine("Have a nice Day...");
                Console.Write("Do you want to see the message 1.Yes 0.No : ");
            }
        }
    }
}
