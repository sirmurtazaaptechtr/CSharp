using System;
using Jun062022_1;

namespace Jun062022_1
{
    internal class Program
    {       
        static void Main()
        {
            int a = 5, b = 10, c;

            //a = 5;
            //b = 10;
            c = a + b;

            Console.WriteLine("{0} and {1} is {2} ",a,b,c);

            bool boolTest = true;
            short byteTest = 1;
            int intTest;
            string stringTest = "Abdullah";
            float floatTest;
            intTest = 140000;
            floatTest = 14.5f;

            Console.WriteLine("Bool Test = {0}", boolTest);
            Console.WriteLine("Byte Test = {0}", byteTest);
            Console.WriteLine("Int Test = {0}", intTest);
            Console.WriteLine("String Test = {0}", stringTest);
            Console.WriteLine("Float Test = {0}", floatTest);

            /*Implicitly Type Variable*/

            var vboolTest = false;
            var vbyteTest = 0;
            var vintTest = 280000;
            var vstringTest = "Huzaifa";
            var vfloatTest = 22.7f;

            Console.WriteLine("Bool Test = {0}", vboolTest);
            Console.WriteLine("Byte Test = {0}", vbyteTest);
            Console.WriteLine("Int Test = {0}", vintTest);
            Console.WriteLine("String Test = {0}", vstringTest);
            Console.WriteLine("Float Test = {0}", vfloatTest);

            Program.newMain("I love C#");

            const float pi = 3.14f;
            float r = 1.2f;

            Console.WriteLine("Area of Circle is {0} with Radius {1}", Program.AreaOfCircle(pi, r), r);


            r = 0.5f;

            Console.WriteLine("Area of Circle is {0} with Radius {1}", Program.AreaOfCircle(pi, r), r);

        }
        /// <summary>
        /// I love C#
        /// This is my newMain function it will be executed Last
        /// after the rest of the code.
        /// </summary>
        static void newMain(string s)
        {
            Console.WriteLine(s);

        }
        static float AreaOfCircle(float PI,float R)
        {
            return PI * R * R;
        }

    }  
    
}