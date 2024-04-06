using System;
using System.Security.AccessControl;

namespace Apr062024_2
{
    class Student
    {
        //fields
        private int _id;
        private string _name;
        private string _email;
        //properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        //Automatic Properties (Short Hand) 
        public string Phone { get; set; }
    }
    internal class Program
    {
        
        static void Main()
        {
            Student s1 = new Student();
            s1.Id = 1;
            s1.Name = "Anshara Rizwan";
            s1.Email = "anshararizwan48@gmail.com";
            s1.Phone = "0300-1234567";

            Console.WriteLine($"ID : {s1.Id}\nName : {s1.Name}\nEmail : {s1.Email}\nPhone : {s1.Phone}");
        }
    }
}
