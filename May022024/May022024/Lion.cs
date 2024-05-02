using System;

namespace May022024
{
    internal class Lion : Carnivorous
    {
        public override void MakeSound()
        {
            Console.WriteLine($"The {Name} says: Roar Roar");
        }
    }
}
