using System;
namespace Mar212023_1
{
    interface I1
    {
        void InterfaceMethod();
    }
    interface I2 
    {
        void InterfaceMethod();
    }
    class MyClass : I1, I2
    {
        void I1.InterfaceMethod() 
        {
            Console.WriteLine("This is Interface Method 1");
        }  
        void I2.InterfaceMethod() 
        {
            Console.WriteLine("This is Interface Method 2");
        }  
    }
    internal class Program
    {
        static void Main()
        {
            //MyClass myClass = new MyClass();            

            //((I1)myClass).InterfaceMethod();
            //((I2)myClass).InterfaceMethod();

            I1 i1 = new MyClass();
            i1.InterfaceMethod();

            I2 i2 = new MyClass();
            i2.InterfaceMethod();
        }
    }
}