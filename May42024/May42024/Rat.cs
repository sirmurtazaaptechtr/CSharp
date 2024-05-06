using System;

namespace May42024
{
    internal class Rat : IAnimal, IOmnivore
    {
        public string Name {get;set;}
        public string Food {get;set;}

        public void AnimalSound()
        {
            Console.WriteLine($"{Name} says : squeak squeak....");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating {Food}.");
        }

        public void Run()
        {
            Console.WriteLine($"{Name} is running here and there.");
        }
    }
}
