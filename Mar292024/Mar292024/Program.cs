using System;


namespace Mar292024
{
    internal class Program
    {
        static void Main()
        {
            Car c1 = new Car();
            c1.make = "Suzuki";
            c1.model = "WaganR";
            c1.color = "White";
            c1.year = 2016;
            c1.maxSpeed = 280;
            
            Car.ClassInfo();

            Car c2 = new Car();
            c2.make = "Toyota";
            c2.model = "Corolla";
            c2.color = "White";
            c2.year = 2020;
            c2.maxSpeed = 380;

            c1.CarInfor();
            c1.FullThrottle();
            c2.CarInfor();
            c2.FullThrottle();


        }
    }
}
