using System;

namespace Dec212023
{
    public delegate void MyDel();

    internal class Program
    {
        static void Main()
        {
            //MyDel md1, md2, md3, md4;
            //md1 = new MyDel(Method1);
            //md2 = new MyDel(Method2);
            //md3 = new MyDel(Method3);            
            //md4 = md2 + md1 + md3;
            //md4();

            MyDel md = new MyDel(Method1);
            md += new MyDel(Method2);
            md += new MyDel(Method3);

            md();

        }
        public static void Method1()
        {
            Console.WriteLine("This is Method 1");
        }
        public static void Method2()
        {
            Console.WriteLine("This is Method 2");
        }
        public static void Method3()
        {
            Console.WriteLine("This is Method 3");
        }
    }
}
