using System;

internal class Program
{
    static void Main()
    {
        string ans = "Y";
        int tab;
        while(ans == "Y" || ans == "y" || ans == "yes")
        {
            Console.Write("Enter Table Number : ");
            tab = int.Parse(Console.ReadLine());
            
            for(int cnt = 1;cnt < 10;cnt++)
            {
                Console.WriteLine("{0} X {1} = {2}",tab,cnt,tab*cnt);
            }
            Console.Write("Do you want to print another table (Y/N) : ");
            ans = Console.ReadLine();
        }
    }
}