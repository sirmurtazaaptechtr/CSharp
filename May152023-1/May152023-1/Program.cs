using System;
using System.IO;

namespace May152023_1
{
    internal class Program
    {
        static void Main()
        {
            string path = @"D:\test.txt";            
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(path);
                string content = streamReader.ReadToEnd();
                Console.WriteLine(content);
                
            }            
            catch (FileNotFoundException ex)
            {
                //Console.WriteLine(ex.ToString());
                //Console.WriteLine(ex.StackTrace);
                //Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.FileName);
                Console.WriteLine("File not found...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                streamReader.Close();
            }
        }
    }
}
