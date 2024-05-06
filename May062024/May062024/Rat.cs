using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May062024
{
    internal class Rat : IAnimal, IOmnivore
    {
        public string Name { get; set; }
        public string Food { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating  {Food}");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} says : chu chu");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping");
        }
    }
}
