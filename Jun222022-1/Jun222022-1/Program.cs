using System;
internal class Program
{
    static void Main()
    {
        Console.WriteLine("~~~Welcome to Series Generator~~~");
        int op = 0;
        bool isValidOption;
        bool isValidNum1;
        bool isValidNum2;
        do
        {
            Console.Write("1.Even Numbers\n2.Odd Numbers\n3.Whole Numbers\n4.Exit\nEnter Your Choice(1 - 4) : ");
            isValidOption = int.TryParse(Console.ReadLine(), out op);
            if (isValidOption && op >= 1 && op <= 4)
            {
                int st,ed;
                do
                {
                    Console.Write("Enter Start : ");
                    isValidNum1 = int.TryParse(Console.ReadLine(), out  st);
                    Console.Write("Enter End : ");
                    isValidNum2 = int.TryParse(Console.ReadLine(), out ed);
                    if(isValidNum1 && isValidNum2 && st < ed)
                    {
                        switch (op)
                        {
                            case 1:
                                Console.WriteLine("EVEN Numbers");
                                for(int cnt = st; cnt <= ed; cnt++)
                                {
                                    if(cnt%2 == 0)
                                    {
                                        Console.WriteLine(cnt);
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("ODD Numbers");
                                for (int cnt = st; cnt <= ed; cnt++)
                                {
                                    if (cnt % 2 != 0)
                                    {
                                        Console.WriteLine(cnt);
                                    }
                                }
                                break;
                            case 3:
                                Console.WriteLine("Whole Numbers");
                                for (int cnt = st; cnt <= ed; cnt++)
                                {                                    
                                    Console.WriteLine(cnt);                                   
                                }
                                break;
                            case 4:
                                Console.WriteLine("Thank You!\nbye");
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid Number!\nTry again");
                    }
                }while(isValidNum1 == false || isValidNum2 == false || st >= ed);                
            }
            else
            {
                Console.WriteLine("Invalid Input!\nTry again.");
            }
        }while (op < 1 || op > 4 || isValidOption != true);
    }
}
