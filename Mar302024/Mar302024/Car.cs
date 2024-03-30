using System;

namespace Mar302024
{
    internal class Car
    {
        // Class members
        // Fields
        public static string CompanyName = "Ahmed Motors";// static field
        public string color;        // field
        public int maxSpeed;        // field

        // Methods
        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        public void CarInfor()  // method
        {
            Console.WriteLine($"Welcome to {CompanyName}\nThe color of my car is {this.color} and it's max speed is {this.maxSpeed}km/hr");
        }

        public static void ClassInfo () // static method
        {
            Console.WriteLine("This is Car Class");
        }

    }
}
