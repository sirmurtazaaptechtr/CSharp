using System;

namespace Apr042024
{
    
    internal class Program
    {
        private int number = 12;

        static void Main()
        {
            Program p1 = new Program();
            Console.WriteLine(p1.number);

            Car c1 = new Car("ABC-123");
            Car c2 = new Car("XYZ-987");

            Console.WriteLine($"Reg# : {c1.Get_Reg_Num()}\nModel : {c1.model}");

            c2.model = "Civic";
            Console.WriteLine($"Reg# : {c2.Get_Reg_Num()}\nModel : {c2.model}");
        }
    }
}