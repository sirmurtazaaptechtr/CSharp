using System;
internal class Program
{
    static void Main()
    {
        int tar, cnt;
        Console.Write("Enter Your Target:");
        tar = int.Parse(Console.ReadLine());
        
        //for(cnt = 1;cnt <= tar;cnt++)
        //{
        //    Console.WriteLine(cnt);
        //}

        //cnt = 1;
        //while(cnt <= tar)
        //{
        //    Console.WriteLine(cnt);
        //    cnt++;
        //}
        
        cnt = 1;
        do
        {
            Console.WriteLine(cnt);
            cnt++;
        }while(cnt <= tar);
        Console.Read();
    }
}