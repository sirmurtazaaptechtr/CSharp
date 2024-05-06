using System;

namespace May032024
{
    abstract class Omnivores : Animal
    {
        public string Food {  get; set; }
        
        public abstract void Eat ();
    }
}
