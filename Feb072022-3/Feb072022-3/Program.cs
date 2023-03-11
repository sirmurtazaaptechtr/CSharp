using System;

internal class Program
{
    static void Main()
    {
        string userChoice = string.Empty;
        int tab, cnt, st = 1, ed = 10;
        do
        {
            Console.Write("Enter Table Number: ");
            tab = int.Parse(Console.ReadLine());

            for (cnt = st; cnt <= ed; cnt++)
            {
                Console.WriteLine("{0} X {1} = {2}", tab, cnt, tab * cnt);
            }
            do {
                Console.Write("\nDo you like to print another table? (Yes/No): ");
                userChoice = Console.ReadLine().ToUpper();
                if(userChoice != "YES" && userChoice != "NO")
                {
                    Console.WriteLine("Invalid Choice!");
                }
            } while (userChoice != "YES" && userChoice != "NO");          

        } while (userChoice != "NO");
        Console.WriteLine("Tank you for using table app\nHave a nice Day! ");
        
        Console.Read();
    }
}