using System;

namespace May062024
{
    internal class Lion : IAnimal, ICarnivores
    {
        public string Name { get; set; }    
        public string Prey { get; set; }

        public void Hunt()
        {
            Console.WriteLine($"{Name} is eating  {Prey}");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} says : ROR");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping");
        }

    }
}
