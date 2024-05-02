using System;

namespace May022024
{
    internal class Program
    {
        static void Main()
        {
            Cat c1 = new Cat();
            c1.Name = "Mano Billi";
            c1.MakeSound();
            c1.Sleep();

            Dog d1 = new Dog();
            d1.Name = "Tommy";
            d1.MakeSound();
            d1.Sleep();

            Lion l1 = new Lion();
            l1.Name = "Simba";
            l1.MakeSound();
            l1.Prey = "Deer";
            l1.Eat();
            l1.Sleep();
        }
    }
}
