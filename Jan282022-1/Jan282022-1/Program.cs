using System;
class Program
{
    static void Main()
    {
        //float f = 1147483600.14159F;
        //int i;

        //i = (int)f;
        //i = Convert.ToInt32(f);

        //Console.WriteLine(i);

        string strNum = "300";
        int iNum = 0;
        //iNum = int.Parse(strNum);
        //Console.WriteLine(iNum);

        bool parseResult = int.TryParse(strNum,out iNum);

        if (parseResult)
        {
            Console.WriteLine(iNum);
        }
        else
        {
            Console.WriteLine("Input is not a valid number");
        }


        Console.Read();
    }
}

