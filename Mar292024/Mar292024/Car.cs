using System;

namespace Mar292024
{
    internal class Car
    {
        // Class members

        // Field
        public string make;
        public string model;
        public string color;
        public int year;
        public int maxSpeed;

        // Methods
        public void FullThrottle()   
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        public void CarInfor()
        {
            Console.WriteLine($"Make : {this.make}\nModel : {this.model}\nColor: {this.color}\nYear : {this.year}\nMax Speed : {this.maxSpeed}km/hr\n");
        }
        public static void ClassInfo ()
        {
            Console.WriteLine("This is Car Class");
        }
    }
}