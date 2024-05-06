using System;

namespace May032024
{
    class Dog : Omnivores
    {

        public override void Eat()
        {
            Console.WriteLine($"{Name} eats {Food}");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Woof, woof");            
        }
    }
}
