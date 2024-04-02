using System;

namespace Apr022024
{
    class Car
    {
        public string regNumber;
        public string model;
        public string color;
        public string year;

        //public Car() {}

        public Car (string RegNum)
        {
            this.regNumber = RegNum;
        }
        public Car(string RegNum,string model,string year)
        {
            this.regNumber = RegNum;
            this.model = model;
            this.year = year;
        }

        public void ShowCar ()
        {
            Console.WriteLine($"Registration Number : {this.regNumber}\nModel : {this.model}\nColor : {this.color}\nYear : {this.year}");
        }
    }

    internal class Program
    {
        static void Main()
        {
            Car c1 = new Car("ABC-123");
            Car c2 = new Car("BGZ-423","WaganR","2016");
            c2.color = "White";
            Car c3 = new Car("XYZ-987","Civic","2019");
            
            c2.ShowCar();
        }
    }
}