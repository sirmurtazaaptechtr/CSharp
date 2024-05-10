using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May072024_1
{
    class Dog : IAnimal, IOmnivorous
    {
        public string Name { get; set; }
        public string Food { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating {Food}");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} says : woof woof");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping..");
        }
    }
}
