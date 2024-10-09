using System;

namespace Sep272024
{
    class Student
    {
        public static string schoolname;
        int id;
        public string fullname;
        public string email;
        public int age;        

        public Student(int GRNumber) 
        {
            id = GRNumber;            
        }

        public void ShowBio ()
        {
            Console.WriteLine($"\nSchool:{schoolname}\nName:{fullname}\nEmail:{email}\nAge:{age}");
        }
    }
    class Circle
    {
        static float pi = 3.14f;
        public float r = 0;

        public static float ValueOfPi ()
        {
            return pi;
        }

        public void Area ()
        {
            Console.WriteLine($"The Area of Circle with radius {r} is {2 * pi * r * r}");
        }
    }
    internal class Program
    {
        static void Main()
        {
            //Circle.pi = 12;

            Circle c1 = new Circle();
            Circle c2 = new Circle();
            
            c1.r = 0.5f;            
            c1.Area();
            Console.WriteLine($"Value of pi is {Circle.ValueOfPi()}");

            c2.r = 0.75f;
            c2.Area();

            Student.schoolname = "ABC Public School";
            Student s1 = new Student(1);
            Student s2 = new Student(2);

            s1.fullname = "Sadaf Irshad";
            s1.email = "sadafahmed097@gmail.com";
            s1.age = 22;

            s1.ShowBio();
            
            s2.fullname = "Javeria Shafique";
            s2.email = "javeria775@gmail.com";
            s2.age = 20;

            s2.ShowBio();
            s1.ShowBio();

        }
    }
}
