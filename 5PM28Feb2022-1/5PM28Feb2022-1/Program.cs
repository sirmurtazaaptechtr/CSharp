using System;
internal class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;
        int c = a + b;
        Console.WriteLine("{0} + {1} = {2}", a, b, c);
        c = a - b;
        Console.WriteLine("{0} - {1} = {2}", a, b, c);
        c = a * b;
        Console.WriteLine("{0} x {1} = {2}", a, b, c);
        float f = (float)a / b;
        Console.WriteLine("{0} / {1} = {2}", a, b, f);
        Console.Write("Enter any number : ");
        //int num = int.Parse(Console.ReadLine());
        int num = Convert.ToInt32(Console.ReadLine());
        //if(num%2 == 0)
        //{
        //    Console.WriteLine("{0} is even", num);
        //}
        //else
        //{
        //    Console.WriteLine("{0} is odd", num);
        //}
        
        string msg = num % 2 == 0 ? num + " is even" : num + " is odd";
        Console.WriteLine(msg);
        //---------example of null operator----------
        bool? AreYouStudent = null;

        if(AreYouStudent == true)
        {
            Console.WriteLine("You go to school.");
        }else if(AreYouStudent == false)
        {
            Console.WriteLine("You do not go to school.");
        }
        else
        {
            Console.WriteLine("User has not provided the answer.");
        }

        Console.Read();
    }
}