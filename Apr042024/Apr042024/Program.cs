using System;

namespace Apr042024
{
    class Car
    {
        private string reg_num;
        public string model = "Suzuki";

        public Car (string Reg_Num) 
        {
            this.reg_num = Reg_Num;
        } 
        public string Get_Reg_Num ()
        {
            return this.reg_num;
        }
        public void CarInfo ()
        {

        }
    }
    internal class Program
    {
        private int number = 12;

        static void Main()
        {
            Program p1 = new Program();
            Console.WriteLine(p1.number);

            Car c1 = new Car("ABC-123");
            Console.WriteLine($"Reg# : {c1.Get_Reg_Num()}\nModel : {c1.model}");
        }
    }
}