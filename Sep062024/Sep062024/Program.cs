using System;

namespace Sep062024
{
    internal class Program
    {
        static void Main()
        {
            // example 1
            int tab;

            Console.Write("Enter Table Number : ");
            tab = int.Parse(Console.ReadLine());
            
            for (int cnt = 1; cnt <= 10; cnt++) 
            {
                Console.WriteLine($"{tab} X {cnt} = {tab*cnt}");
            }

            // example 2            
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            
            for (int index = 0;index < cars.Length;index++) 
            {
                Console.WriteLine(cars[index]);
            }

            foreach (string car in cars) 
            {
                Console.WriteLine(car);
            }

            // example 3            
            for(int i = 1; i <= 10; i++)
            {                
                if(i == 6)
                {
                    break;
                }
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}
