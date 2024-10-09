using System;
using System.Text.RegularExpressions;

namespace Oct022024
{
    /// <summary>
    /// Represents a student with a full name.
    /// </summary>
    class Students
    {
        /// <summary>
        /// Stores the full name of the student.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Sets the full name of the student. Validates the input to ensure
        /// it contains only alphabetic characters, hyphens, apostrophes, and spaces.
        /// If the input is invalid, assigns "No Name" as the default value.
        /// </summary>
        /// <param name="FullName">The full name to be set.</param>
        public void SetFullName(string FullName)
        {
            // Regular expression for validating names (only letters, hyphens, apostrophes, and spaces allowed).
            string FullNameRegex = @"(^[a-zA-Z-' ]*$)";

            Regex ex = new Regex(FullNameRegex);

            // Set fullname if the input is valid, otherwise default to "Anonymous".
            if (ex.IsMatch(FullName))
            {
                this._fullname = FullName;
            }
            else
            {
                this._fullname = "Anonymous";
            }
        }

        /// <summary>
        /// Retrieves the full name of the student.
        /// </summary>
        /// <returns>The student's full name.</returns>
        public string GetFullName()
        {
            return this._fullname;
        }
    }

    /// <summary>
    /// The main entry point of the application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The Main method creates a student instance, sets a full name, and prints a greeting.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        static void Main(string[] args)
        {
            // Create instances of the Students class.
            Students s1 = new Students();
            Students s2 = new Students();

            // Set the full name of the students.
            s1.SetFullName("Sadaf Irshad");            
            s2.SetFullName("Javeria Shafique");            
            

            // Print a greeting with the student's full name.
            Console.WriteLine($"Hi {s1.GetFullName()}");
            Console.WriteLine($"Hi {s2.GetFullName()}");
        }
    }
}