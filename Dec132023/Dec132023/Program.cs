using System;

namespace Dec132023
{
    interface I1
    {
        void Print();
    }
   interface I2
    {
        void Print();
    }

    abstract class Pclass
    {
        int _a = 10;
        public abstract void Print();
        public void Print2  () 
        {
            Console.WriteLine("This is print 2 of Pclass");
        }
    }
    class Cclass : Pclass
    {
        public override void Print ()
        {
            Console.WriteLine("this is Print Method ");
        }
    }
    internal class Program : I1, I2
    {
        static void Main()
        {
            Cclass cc = new Cclass();
            cc.Print();
            cc.Print2();

            //Program p = new Program();
            //((I1)p).Print();
            //((I2)p).Print();

            I1 i1 = new Program();
            I2 i2 = new Program();

            i1.Print();
            i2.Print(); 
        }

        void I1.Print()
        {
            Console.WriteLine("This is an interface I1 Method");
        }
        void I2.Print()
        {
            Console.WriteLine("This is an interface I2 Method");
        }
    }
}
