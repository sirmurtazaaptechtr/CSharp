using System;

namespace Sep112024
{
    internal class Program
    {
        static void Greetings(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        static int Squrer(int number) // parameter of the function
        {
            return number * number;
        }

        static void Main()
        {
            /*
             * When a parameter is passed to the method, it is called an argument. So, from the example above: name is a parameter, while Sadaf, Javeria, Uzair and Murtaza are arguments.
            */
            Greetings("Sadaf");
            Greetings("Javeria");
            Greetings("Uzair");
            Greetings("Murtaza");

            int num = 7;
            int res = Squrer(num);// argument to the function
            Console.WriteLine($"the square of {num} is {res}");
        }


    }
}
