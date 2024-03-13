using System;

namespace Mar132024
{
    internal class Program
    {
        static void Main()
        {
            string fullName = "", firstName = "", midName = "", lastName = "";
            char ch = ' ';

            Console.Write("Enter Full Name : ");
            fullName = Console.ReadLine();

            //Console.WriteLine($"\"{fullName}\" has {fullName.Length} characters in it.");
            //Console.WriteLine(fullName[6]);
            //Console.WriteLine(fullName.IndexOf(ch));
            //Console.WriteLine(fullName.IndexOf(ch, fullName.IndexOf(ch) + 1));

            //firstName = fullName.Substring(0, fullName.IndexOf(ch));
            //midName = fullName.Substring(fullName.IndexOf(ch) + 1, fullName.IndexOf(ch, fullName.IndexOf(ch) + 1) - fullName.IndexOf(ch));
            //lastName = fullName.Substring(fullName.IndexOf(ch, fullName.IndexOf(ch) + 1)+1);

            //Console.WriteLine($"Full Name : {fullName}");
            //Console.WriteLine($"First Name : {firstName}");
            //Console.WriteLine($"Middle Name : {midName}");
            //Console.WriteLine($"Last Name : {lastName}");

            string[] nameParts = fullName.Split(ch);

            int len = nameParts.Length;

            switch(len)
            {
                case 1:
                    firstName = nameParts[0];
                break;
                case 2:
                    firstName = nameParts[0];
                    lastName = nameParts[1];
                break;
                case 3:
                    firstName = nameParts[0];
                    midName = nameParts[1];
                    lastName = nameParts[2];
                break;
            }            

            Console.WriteLine($"First Name : {firstName}");
            Console.WriteLine($"Middle Name : {midName}");
            Console.WriteLine($"Last Name : {lastName}");
        }
    }
}