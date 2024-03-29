using System;

namespace Mar272024
{
    
    internal class Program
    {
        static void MyMethod () 
        {
            Console.WriteLine("This is my Method.");
        }
        static void MyMethod (string name) 
        {
            Console.WriteLine($"Dear {name}, how do you do?");
        }
        static void MyMethod (int age, string name) 
        {
            Console.WriteLine($"Dear {name}, how do you do? You are {age} years old.");
        }
        static void Main()
        {
            MyMethod();
            MyMethod("Ali Raza");
            MyMethod(18,"Ali Raza");

            Car c1 = new Car();
            c1.color = "red";
            Console.WriteLine($"The color of the car is {c1.color}");            
            c1.Drive ();

            Car c2 = new Car();
            c2.color = "blue";
            c2.Drive ();
        }
    }
}
