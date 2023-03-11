using System;
namespace Feb142023_1
{
    internal class Program
    {
        static void Main()
        {
            int i = 10;
            Program p = new Program();
            Console.WriteLine("B:Outside myFun i = {0}", i);
            p.myFun(i);
            Console.WriteLine("A:Outside myFun i = {0}", i);

            Console.WriteLine("B:Outside myFun2 i = {0}", i);
            p.myFun2(ref i);
            Console.WriteLine("A:Outside myFun2 i = {0}", i);

        }
        public void myFun(int i)
        {
            Console.WriteLine("B:Inside myFun i = {0}",i);
            i++;
            Console.WriteLine("A:Inside myFun i = {0}",i);
        }
        public void myFun2(ref int i)
        {
            Console.WriteLine("B:Inside myFun2 i = {0}", i);
            i++;
            Console.WriteLine("A:Inside myFun2 i = {0}", i);

        }
    }
}
