using System;
internal class Program
{
    static void Main()
    {
        string UserChoice = String.Empty;
        do
        {
            Console.Write("Please Enter you target : ");
            int UserTarget = int.Parse(Console.ReadLine());

            int start = 0;

            while(start <= UserTarget)
            {
                Console.WriteLine(start);
                start++;
            }
            do
            {
                Console.Write("Do you want to continue - Yes or No? : ");
                UserChoice = Console.ReadLine();
                if (UserChoice != "Yes" && UserChoice != "No")
                {
                    Console.WriteLine("Please Enter 'Yes' or 'No'");
                }
            } while (UserChoice != "Yes" && UserChoice != "No");
        }while(UserChoice == "Yes");
    }
}