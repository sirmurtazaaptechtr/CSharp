using System;


namespace May022024
{
    abstract class Carnivorous : Animal
    {
        public string Prey {  get; set; }
        public void Eat ()
        {
            Console.WriteLine($"{Name} is eating {Prey}");
        }

    }
}
