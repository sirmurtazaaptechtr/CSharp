using System;

namespace May022024
{
    abstract class Animal
    {
        public string Name { get; set; }

        public void Sleep () 
        {
            Console.WriteLine($"{Name} is sleeping...");
        }
        public abstract void MakeSound();
    }
}
