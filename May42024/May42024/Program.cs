using System;
namespace May42024
{
    internal class Program
    {
        enum Days
        {
            Sunday = 1,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday            
        }
        enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main()
        {
            Rat r1 = new Rat();
            r1.Name = "Jerry";
            r1.Food = "Cheese";
            r1.AnimalSound();
            r1.Eat();
            r1.Run();

            Days din = Days.Saturday;
            Months mahena = Months.May;
            
            Console.WriteLine($"{din} is at index # {(int)din}");
            Console.WriteLine($"{mahena} is at index # {(int)mahena}");
        }
    }
}
