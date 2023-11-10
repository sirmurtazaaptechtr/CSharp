using System;

public delegate void MyDelegate(string Msg);

namespace Apr012023_1
{
    internal class Program
    {
        static void Main()
        {
            MyDelegate del = new MyDelegate(dispMsg);
            del("Welcome to my class, this is delegate.");
        }
        public static void dispMsg(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
