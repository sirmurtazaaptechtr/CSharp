using System;

namespace Dec122023
{
    interface I1
    {
        void Print();
    }
    interface I2
    {
        void Print();
    }

    internal class Program : I1, I2
    {
        static void Main()
        {
            //Program prog = new Program();
            //((I1)prog).Print();
            //((I2)prog).Print();

            I1 i1 = new Program();
            I2 i2 = new Program();
            i1.Print();
            i2.Print();
        }

        void I1.Print()
        {
            Console.WriteLine("I1 implementation");
        }

        void I2.Print()
        {
            Console.WriteLine("I2 implementation");
        }
    }
}
