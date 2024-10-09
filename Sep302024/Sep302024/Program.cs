using System;

namespace Sep302024
{
    class MyClass
    {
        int age;

        public int GetAge ()
        {
            return age;
        }
        public void SetAge(int Age)
        {
            if (Age > 0)
            {
                age = Age;
            }
            else
            {
                Console.WriteLine("Age must be a positive integer");
            }
        }
    }
    class ChildClass:MyClass
    {

    }
    internal class Program
    {
        static void Main()
        {
            MyClass mc = new MyClass();
            Console.Write("Enter Your Age: ");
            mc.SetAge(Int32.Parse(Console.ReadLine()));
            Console.WriteLine($"You are {mc.GetAge()}years old.");

            ChildClass mc2 = new ChildClass();
            
        }
    }
}
