using System;

namespace May022024
{
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"The {Name} says: Meow Meow");
        }
    }
}
