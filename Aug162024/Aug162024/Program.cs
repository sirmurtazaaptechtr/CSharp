using System;

namespace Aug162024
{
    internal class Program
    {
        static void Main()
        {
            // C# Variables
            string name = "Javeria Shafique";
            int age; // declaration statement
            age = 18; // initilization statement
            //double salary = 125455.25;
            //float salary = 125455.25f;
            decimal salary = 125455.25m;

            // Composite format string
            Console.WriteLine("Dear {1}, You are {0} years old.\nYour Salary is {2}", age, name, salary);
            Console.WriteLine("Dear {0}, You are {1} years old.\nYour Salary is {2:C2}", name, age, salary);

            //string concatenation
            Console.WriteLine("Dear " + name + ", You are " + age + " years old.");

            string[] names = { "Adam", "Bridgette", "Carla", "Daniel",
                   "Ebenezer", "Francine", "George" };
            decimal[] hours = { 40, 6.667m, 40.39m, 82,
                    40.333m, 80, 16.75m };

            Console.WriteLine("{0,-20} {1,5:N1}\n", "Name", "Hours");
            for (int counter = 0; counter < names.Length; counter++)
            {
                Console.WriteLine("{0,-20} {1,5:N1}", names[counter], hours[counter]);
            }
            /*
            This Console.WriteLine statement in C# is formatting and printing text with specific alignment and number formatting. Here's a breakdown of what each part does:
            "{0,-20} {1,5:N1}\n": This is the format string.
            {0,-20}: The first placeholder({ 0}) represents the first argument("Name"). The - 20 specifies left alignment within a 20 - character wide field.
            { 1,5:N1}: The second placeholder({ 1}) represents the second argument("Hours"). The 5 specifies right alignment within a 5 - character wide field, and N1 formats the number with one decimal place and includes thousands separators if necessary.
            \n: This is a newline character that moves the cursor to the next line after the output.
            */

        }
    }
}
