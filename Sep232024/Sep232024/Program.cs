using System;

namespace Sep232024
{
    // Class representing Students with basic attributes
    class Students
    {
        // Fields to store student's full name, age, and gender
        public string fullname;
        public int age;
        public string gender;

        // Method to print student's details
        public void Print()
        {
            // Output the student's information in a formatted string
            Console.WriteLine($"My name is {this.fullname}. I am {this.age} years old {this.gender}.");
        }
    }

    // Method Overloading - Polymorphism Example
    internal class Program
    {
        // Sum method to handle two integers
        static void Sum(int a, int b)
        {
            // Output the sum of two integers
            Console.WriteLine($"IntegerSum\n{a} + {b} = {a + b}");
        }

        // Sum method to handle two floats
        static void Sum(float a, float b)
        {
            // Output the sum of two floats
            Console.WriteLine($"FloatSum\n{a} + {b} = {a + b}");
        }

        // Sum method to handle two doubles
        static void Sum(double a, double b)
        {
            // Output the sum of two doubles
            Console.WriteLine($"DoubleSum\n{a} + {b} = {a + b}");
        }

        // Sum method to handle a variable number of float arguments using params
        static void Sum(params float[] numbers)
        {
            float total = 0;

            // Loop through the array of floats and calculate the total sum
            foreach (float number in numbers)
            {
                total += number;
            }

            // Output the total sum of all float numbers
            Console.WriteLine($"The Sum is {total}");
        }

        // Main method where execution starts
        static void Main()
        {
            // Call the Sum method for integers
            Sum(2, 3);

            // Call the Sum method for floats
            Sum(2.5f, 3.7f);

            // Call the Sum method with multiple float values using params
            Sum(1.75f, 2, 7.5f, 3.3f, 17); // Error in float casting (fix: add 'f' for float values)

            // Create instances of the Students class
            Students std1 = new Students();
            Students std2 = new Students();
            Students std3 = new Students();

            // Assign values to the first student's fields
            std1.fullname = "Sadaf Irshad";
            std1.age = 22;
            std1.gender = "female";

            // Assign values to the second student's fields
            std2.fullname = "Javeriya Shafiq";
            std2.age = 21;
            std2.gender = "female";

            // Assign values to the third student's fields
            std3.fullname = "Uzair";
            std3.age = 20;
            std3.gender = "male";

            // Call the Print method for each student to display their details
            std1.Print();
            std2.Print();
            std3.Print();
        }
    }
}
