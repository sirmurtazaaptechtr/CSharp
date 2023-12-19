using System;
using System.Collections.Generic;

namespace Dec182023
{
    public delegate void MyDel(string msg);

    internal class Program
    {
        static void Main(string[] args)
        {
            //MyDel md1, md2, md3, md4;
            //md1 = new MyDel(MyFun1);
            //md2 = new MyDel(MyFun2);
            //md3 = new MyDel(MyFun3);

            //md4 = md1 + md2 + md3;

            MyDel md4 = new MyDel(MyFun1);
            md4 += new MyDel(MyFun2);
            md4 += new MyDel(MyFun3);

            List<string> names = new List<string>();
            names.Add("Ahsan Khan");
            names.Add("Khurram");
            names.Add("Mani");
            foreach(string name in  names)
            {
                md4(name);
            }
        }
        public static void MyFun1 (string msg)
        {
            Console.WriteLine("Hello " + msg);
        }        
        public static void MyFun2 (string msg)
        {
            Console.WriteLine("How are you? " + msg);
        }
        public static void MyFun3 (string msg)
        {
            Console.WriteLine("Where are you? " + msg);
        }
    }
}
