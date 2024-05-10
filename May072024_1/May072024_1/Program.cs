using System;

namespace May072024_1
{
    internal class Program
    {
        static void Main()
        {
            Dog d1 = new Dog();
            d1.Name = "Tommy";
            d1.Food = "Meat";
            d1.MakeSound();
            d1.Eat();
            d1.Sleep();
        }
    }
}
