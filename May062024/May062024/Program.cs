using System;

namespace May062024
{
    internal class Program
    {
        static void Main()
        {
            Lion l1 = new Lion();
            l1.Name = "Simba";
            l1.Prey = "Deer";
            l1.MakeSound();
            l1.Hunt();
            l1.Sleep();

            Rat r1 = new Rat();
            r1.Name = "Jerry";
            r1.Food = "Cheese";
            r1.MakeSound();
            r1.Eat();
            r1.Sleep();

            Parent c1 = new Parent();
            Parent c2 = new Child();
            c1.Print();
            c2.Print();
        }
    }
}
