using System;

namespace May022024
{
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"The {Name} says: Bow Bow");
        }
    }
}
