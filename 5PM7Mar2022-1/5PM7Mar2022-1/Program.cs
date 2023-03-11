using System;

internal class Program
{
    static void Main()
    {
        abc obj = new abc();

        int n, max, min, sum;
        float avg;
        //For Number of elements to be stored in array
        Console.Write("How many numbers your want to store : ");
        n = int.Parse(Console.ReadLine());
        /*Declearation of an array
         of n elements*/
        int[] nums = new int[n];
        /*For Input, Sum and avg*/
        sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}.Enter Number : ", i + 1);
            nums[i] = int.Parse(Console.ReadLine());
            sum += nums[i];
        }
        avg = (float)sum/ n;
        //For Min and Max
        max = nums[0];
        min = nums[0];
        for (int i = 1; i < n; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }
            if (nums[i] < min)
            {
                min = nums[i];
            }
        }
        Console.WriteLine("Total = {0}\nMin = {1}\nMax = {2}\nAvg = {3}",sum,min,max,avg);
    }
    /// <summary>
    /// this is a sample class. No Special notes are assoicated with it
    /// </summary>
    public class abc
    {

    }
}

