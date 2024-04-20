using System;

namespace Apr192024_Rev
{
    internal class Program
    {
        public string color;
        public string make;
        public int year;
        
        public Program () { }

        public Program (string Color, string Make, int Year)
        {
            this.color = Color;
            this.make = Make;
            this.year = Year;   
            Console.WriteLine("I am Constuctor...");
        }

        public void Print ()
        {
            Console.WriteLine($"Color : {color}\nMake : {make}\nYear : {year}\n");
        }

        static void MyMethod (int age = 18,string gender = "Male", string name = "John")
        {
            Console.WriteLine ($"Name : {name}\nAge : {age}\nGender : {gender}");
        }
        static void addNumbers (int a, int b)
        {
            int c = a + b;
            Console.WriteLine($"Sum of integers is {c}");
        }        
        static void addNumbers (float a, float b)
        {
            float c = a + b;
            Console.WriteLine($"Sum of real numbers is {c}");            
        }
        static void addNumbers (int a, int b, int c)
        {
            int d = a + b + c;
            Console.WriteLine($"Sum of three integers is {d}");
        }
        static void Main()
        {
            Program p1 = new Program ("Red","Honda 125",2023);
            Program p2 = new Program ("White","Suzuki WaganR",2016);
            Program p3 = new Program ("Black","Ford Mustang",2024);
            Program p4 = new Program ("Black","Honda Civic",2023);
            Program p5 = new Program ("Black","Honda Accord",2022);

            addNumbers(1, 2);
            addNumbers(1.8f, 2.5f);
            addNumbers(2, 2.5f);
            addNumbers(1, 2, 3);
            MyMethod();
            MyMethod(22, "male", "Moiz");
            MyMethod(name: "Khizar");
            MyMethod(name: "Saad");           

            for(int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine($"{i} is here i am going...");
                    break;
                }
                Console.WriteLine(i);
            }
            for(int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is Even");
                    continue;
                }
                Console.WriteLine($"{i} is ODD");
            }

            p1.Print();
            p2.Print();
            p3.Print();
            p4.Print();
            p5.Print();
        }
    }
}
