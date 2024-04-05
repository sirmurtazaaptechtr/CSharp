using System;

namespace Apr052024
{
    class Car
    {
        private string reg_no;
        private string make;
        private string model;
        private string color;
        private int year;

        public Car (string Reg_No, string make, string model, int year)
        {
            this.reg_no = Reg_No;
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public void Set_Color (string color)
        {
            this.color = color;
        }
        public string Get_Color () 
        {
            return this.color;
        }
        public string Get_Reg () 
        {
            return this.reg_no;
        }
        public string Get_Make () 
        {
            return this.make;
        } 
        public string Get_Model () 
        {
            return this.model;
        }
        public int Get_Year () 
        {
            return this.year;
        }

        public void Print ()
        {
            Console.WriteLine($"Reg # : {this.reg_no}\nMake : {this.make}\nModel : {model}\nColor : {color}\n Year : {year}");
        }
    }
    internal class Program
    {
        static void Main()
        {
            Car c1 = new Car("ABC-123", "Suzuki", "WaganR", 2016);
            c1.Set_Color("Red");            
            
            c1.Print();
        }
    }
}
