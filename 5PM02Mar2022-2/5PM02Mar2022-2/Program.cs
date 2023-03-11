using System;

internal class Program
{
    static void Main()
    {
        //int num1 = 21;
        //float num2 = 3.5F;
        //int num3 = 4;

        //Console.WriteLine("the sum of {0} and {1} is {2}",num1,num2,num1+num2);        
        //Console.WriteLine("{0} / {1} = {2}",num1,num3,num1/num3);        
        //Console.WriteLine("{0} / {1} = {2}",num1,num3,(float)num1/num3);

        //int i = 100;
        //float f = i;
        //Console.WriteLine(f);

        float f = 3.14159F;
        //int i = (int)f;
        int i = Convert.ToInt32(f);
        Console.WriteLine(i);

        string s = "2.5";
        //i = int.Parse(s);
        //Console.WriteLine(i);

        i = 0;
        
        bool isParseDone = int.TryParse(s, out i);

        if (isParseDone)
        {
            Console.WriteLine(i);
        }else
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}