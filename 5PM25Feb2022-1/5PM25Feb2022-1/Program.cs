using System;
internal class Program
{
    static void Main()
    {
        int i = 123456789;
        long l = 1234567890123456789L;
        float f = 3.123456F;
        double d = 0.123456789012345D;
        float f1 = 35e3F;
        double d1 = 12E4D;
        bool b = true;
        string s = "Basic Data Types and their values.";

        Console.WriteLine(s);
        Console.WriteLine("Integer types(int i) = "+i);
        Console.WriteLine("Integer types(long l) = "+l);
        Console.WriteLine("Floating point types(float f) = " + f);
        Console.WriteLine("Floating point types(double d) = " + d);
        Console.WriteLine("Floating point types(float f1) = " + f1);
        Console.WriteLine("Floating point types(double d1) = " + d1);
        Console.WriteLine("boolean data type(bool b) = " + b);

        Console.WriteLine("My name is \"Syed Murtaza Hussain\".\nI live in Karachi.");

        Console.WriteLine("C:\\Users\\murtaza\\source\\repos");
  
        Console.WriteLine(@"C:\Users\murtaza\source\repos");

        Console.Read();

    }
}