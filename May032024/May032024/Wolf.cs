using System;

namespace May032024
{
    internal class Wolf : Omnivores
    {
        public override void Eat()
        {
            Console.WriteLine($"{Name} eats {Food}");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: howls");
        }
    }
}
