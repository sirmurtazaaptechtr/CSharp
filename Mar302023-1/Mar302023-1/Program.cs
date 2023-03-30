using System;
using System.IO;

namespace Mar302023_1
{
    internal class Program
    {
        static void Main()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(@"D:\Sample Files\Data.txt");
                Console.WriteLine(sr.ReadToEnd());                
            }            
            catch (FileNotFoundException ex) 
            {
                //Console.WriteLine(ex.FileName);                
                //Console.WriteLine(ex.Message);
                Console.WriteLine("File not Found");
            }
            catch (DirectoryNotFoundException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Directory not Found");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                if (sr != null)
                {
                    sr.Close();
                    Console.WriteLine("Stream Reader Closed");
                }
            }
        }
    }
}