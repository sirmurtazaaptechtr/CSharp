using System;

internal class Program
{
    static void Main()
    {
        string userChoice = string.Empty;
        int tab, cnt, st = 1, ed = 10;        
start:
        Console.Write("Enter Table Number: ");
        tab = int.Parse(Console.ReadLine());

        for(cnt = st; cnt <= ed; cnt++)
        {
            Console.WriteLine("{0} X {1} = {2}", tab, cnt, tab * cnt);
        }

        Console.Write("\nDo you like to print another table? (Yes/No): ");
        userChoice = Console.ReadLine().ToUpper();
 
        if(userChoice == "YES" || userChoice == "Y")
        {
            goto start;
        }
        else
        {
            Console.WriteLine("Thank You for using table application\nHave a nice Day!"); 
        }
        Console.Read();
    }
}