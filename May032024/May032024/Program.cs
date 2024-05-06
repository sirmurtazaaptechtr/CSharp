using System;

namespace May032024
{
    internal class Program
    {
        static void Main()
        {           

            Dog d1 = new Dog();
            d1.Name = "Tommy";
            d1.Food = "Biscuits";
            d1.MakeSound();
            d1.Eat();
            d1.Sleep();

            Wolf w1 = new Wolf();
            w1.Name = "Bloody";
            w1.Food = "Watermelon";
            w1.MakeSound();
            w1.Eat();
            w1.Sleep();
        }
    }
}
