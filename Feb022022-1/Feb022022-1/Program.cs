using System;
internal class Program
{
    static void Main()
    {
        //For Loop
        //Example 1:
        //int c,tab;
        //Console.Write("Enter Table Number: ");
        //tab = int.Parse(Console.ReadLine());

        //for(c=1;c<=10;c++)
        //{
        //    Console.WriteLine("{0} X {1} = {2}",tab,c,tab*c);
        //}
        //Example 2:
        //string[] stdNames = { "Muhammad Hamza", "Moiz Ghazali", "Muhammad Faisal", "Yazdan Khan", "Sameed Ansari", "Abdul Rafay" };

        //int cnt;
        //for(cnt=0;cnt<stdNames.Length;cnt++)
        //{
        //    Console.WriteLine("Dear {0}, How are you?",stdNames[cnt]);
        //}
        //Example 3:
        int num1, num2, cnt, sum=0;

        Console.Write("Enter Start Number: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter End Number: ");
        num2 = int.Parse(Console.ReadLine());

        for(cnt = num1; cnt <= num2; cnt++)
        {
            Console.WriteLine(cnt);
            sum = sum + cnt;
        }
        Console.WriteLine("Total = {0}",sum);

        //Example 4:
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        for(int index = 0, row = 1; row <= 3; row++)
        {
            for(int col = 1; col <= 3; col++)
            {
                Console.Write("\t");
                Console.Write(numbers[index]);
                index++;
            }
            Console.Write("\n\n");
        }  
        
        //For each Loop

        //string[] std_R = new string[6] { "Muhammad Hamza", "Moiz Ghazali", "Muhammad Faisal", "Yazdan Khan", "Sameed Ansari", "Abdul Rafay" };

        //foreach (string name in std_R)
        //{
        //    Console.WriteLine("Dear {0}, how are you?",name);
        //}

        Console.Read();
    }
}