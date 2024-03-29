using System;

namespace Mar272024
{
    class Car
    {
        public string color = "White";

        public void Drive()
        {
            Console.WriteLine($"The {this.color} car is running...");
        }
    }
}
