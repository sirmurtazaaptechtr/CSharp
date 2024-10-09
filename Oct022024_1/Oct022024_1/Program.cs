using System;
using System.Text.RegularExpressions;

namespace Oct022024
{
    /// <summary>
    /// Represents a student with a full name.
    /// </summary>
    class Students
    {
        // Private backing field for the FullName property
        private string _fullName;

        /// <summary>
        /// Gets or sets the full name of the student.
        /// </summary>
        public string FullName
        {
            get
            {
                if (_fullName == null)
                {
                    _fullName = "No Name";
                    return _fullName;
                }
                else
                {
                    return _fullName;
                }
            }
            set
            {
                // Regular expression to validate the full name
                string pattern = @"^[a-zA-Z-' ]*$";
                if (Regex.IsMatch(value, pattern))
                {
                    _fullName = value;
                }
                else
                {
                    _fullName = "Wrong Name";
                }
            }
        }
    }

    /// <summary>
    /// The main entry point of the application.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Students class
            Students s1 = new Students();
            Students s2 = new Students();

            // Set the full name of the student
            s1.FullName = "Sadaf Irshad";
            //s1.FullName = "1234";
            s2.FullName = "Javeria Shafique";

            // Print a greeting with the student's full name
            Console.WriteLine($"Hi {s1.FullName}");
            Console.WriteLine($"Hi {s2.FullName}");
        }
    }
}
