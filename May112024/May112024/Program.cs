using System;
using System.IO;

namespace May112024
{
    internal class Program
    {
        enum Size
        {
            Exta_Small,
            Small,
            Medium,
            Large,
            Extra_Large
        }
        enum Level
        {
            Low,
            Medium,
            High
        }
        static void Main()
        {
            Size s = Size.Large;
            Level l = Level.Medium;

            Console.WriteLine($"Size is {s}");   
            Console.WriteLine($"Level is {l}");

            string text = "My name is Hussain.";
            string path = @"D:\May112024.txt";
            string storedtext = "";

            File.WriteAllText(path, text);

            if(File.Exists(path))
            {
                File.AppendAllText(path, " I live in Karachi.");
                storedtext = File.ReadAllText(path);
                Console.WriteLine(storedtext);
                File.Delete(path);
            }

            try
            {
                storedtext = File.ReadAllText(path);
                Console.WriteLine(storedtext);
            }
            catch(Exception e) 
            {               
                //Console.WriteLine(e.Message);
                Console.WriteLine("File not found...");
                File.Copy(path, @"D:\abc.txt");
            }
            finally
            {
                Console.WriteLine("The End");
            }

        }
    }
}
