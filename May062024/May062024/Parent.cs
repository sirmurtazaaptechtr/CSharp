using System;
using System.IO;

namespace May062024
{
    internal class Parent
    {
        public string TextToWrite = "My name is Syed Murtaza Hussain. This is my text.";
        

        enum Days 
        {
            Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

        enum Gender
        {
            Male=1, Female, Others
        }

        Gender gender = Gender.Male;
        Days day = Days.Monday;

        public virtual void Print()
        {
            File.WriteAllText(@"D:\MyTextFile.txt", TextToWrite);
            File.AppendAllText(@"D:\MyTextFile.txt", "Bye Bye!");

            Console.WriteLine($"This is Parent {gender} and {day} ");
            Console.WriteLine($"This is Parent {(int)gender} and {(int)day} ");

            Console.WriteLine(File.ReadAllText(@"D:\MyTextFile.txt"));
        }

    }
}
