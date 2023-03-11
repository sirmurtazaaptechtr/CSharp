using System;
internal class Program
{
    static void Main()
    {
        int[] stdMarks = new int[10] {10,11,21,23,42,51,65,87,48,9};

        //for(int cnt = 0; cnt < stdMarks.Length; cnt++)
        //{
        //    Console.Write("{0}. Enter Marks : ",cnt+1);
        //    stdMarks[cnt] = int.Parse(Console.ReadLine());
        //}

        Console.WriteLine("Displaying Students Result.....");

        int srno = 1; 
        foreach (int marks in stdMarks)
        {            
            Console.WriteLine("{1}. Student Marks = {0}",marks,srno);
            srno++;
        }

        //for(int cnt = 0; cnt < stdMarks.Length; cnt++)
        //{
        //    Console.WriteLine("{1}. Student Marks = {0}",stdMarks[cnt],cnt+1);
        //}
    }
}