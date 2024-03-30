using System;

namespace Mar302024
{
    
    internal class Program
    {
        static void Main()
        {
            Car c1 = new Car();
            c1.color = "red";
            c1.maxSpeed = 180;

            Car c2 = new Car();
            c2.color = "blue";
            c2.maxSpeed = 250;

            c1.CarInfor();
            c2.CarInfor();            

            Car.ClassInfo();
            Console.WriteLine($"Company Name : {Car.CompanyName} ");
        }
    }
}
