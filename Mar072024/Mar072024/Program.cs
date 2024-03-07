using System;

namespace Mar072024
{
    internal class Program
    {
        static void Main()
        {
            //*C# Strings
            string name = "Ali Raza";
            string email = "ali@raza.com";
            string CNIC = "42101-1234567-8";

            //Console.WriteLine("Name : {0}\nEmail : {1}\nCNIC : {2}", name, email, CNIC);

            //**string interpolation
            Console.WriteLine($"Name : {name}\nEmail : {email}\nCNIC : {CNIC}");

            //**string property Length
            Console.WriteLine($"The length of \"{name}\" is {name.Length} characters");
            Console.WriteLine($"The length of \"{email}\" is {email.Length} characters");
            Console.WriteLine($"The length of \"{CNIC}\" is {CNIC.Length} characters");

            //**string methods ToUpper() and ToLower()
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());

            //**String Concatenation
            string firstName = "Anshara";
            string lastName = "Rizwan";
            //string fullName = firstName + " " + lastName; // + operator
            //string fullName = string.Concat( firstName, " ", lastName ); // string.Concat Method
            string fullName = $"{firstName} {lastName}"; // string interpolation
            Console.WriteLine(fullName);

            //**Access Strings
            Console.WriteLine(firstName[0]);
            Console.WriteLine(firstName[1]);
            Console.WriteLine(firstName[2]);
            Console.WriteLine(firstName[3]);
            Console.WriteLine(firstName[4]);
            Console.WriteLine(firstName[5]);
            Console.WriteLine(firstName[6]);

            //**string methods IndexOf() & Substring()
            Console.WriteLine(firstName.IndexOf('s'));

            firstName = name.Substring(0, name.IndexOf(' '));
            lastName = name.Substring(name.IndexOf(' ') + 1);

            Console.WriteLine($"First Name : {firstName}\nLast Name : {lastName}");

            name = "Hamza Irfan";
            Console.WriteLine($"First Name : {name.Substring(0, name.IndexOf(' '))}\nLast Name : {name.Substring(name.IndexOf(' ') + 1)}");

            name = "Huzaifa Khan";
            Console.WriteLine($"First Name : {name.Substring(0, name.IndexOf(' '))}\nLast Name : {name.Substring(name.IndexOf(' ') + 1)}");

            name = "Sheikh Kashan";
            Console.WriteLine("First Name : " + name.Substring(0, name.IndexOf(' ')));
            Console.WriteLine("Last Name : " + name.Substring(name.IndexOf(' ') + 1));

        }
    }
}
