using System;
namespace Nov292023
{
    class Student
    {
        static string Company = "Aptech Learning";
        int _id;
        string _name;
        string _gender;
        int _age;
        public Student()
        {
            
        }
        public Student(int ID)
        {
            this._id = ID;
        }
        public Student(int ID, string Name)
        {
            this._id = ID;
            this._name = Name;
        }
        public void SetName(string Name)
        {
            this._name = Name;
        }
        public void SetGender(string Gender)
        {
            this._gender = Gender;
        }
        public bool SetAge(int Age)
        {
            if(Age <= 0) 
            {
                this._age = 0; 
                return false;
            }
            this._age = Age;
            return true;
        }
        public void Print()
        {
            Console.WriteLine("\nWelcome to {0}", Company);
            Console.WriteLine("ID : {3}\nName : {0}\nGender : {1}\nAge : {2}\n", this._name, this._gender, this._age, this._id);
        }
        ~Student()
        {
            Console.WriteLine("The End");
        }

    }
    internal class Program
    {
        static void Main()
        {
            Student s1 = new Student(1);
            Student s2 = new Student(2);
            Student s3 = new Student(3, "Shayan");
            Student s4 = new Student();

            s1.SetName("Kinza Danish");
            s1.SetGender("female");
            s1.SetAge(20);

            s2.SetName("Rohaan");    ;
            s2.SetGender("male"); 
            s2.SetAge(-19);

            s1.Print();
            s2.Print();
            s3.Print();
            s4.Print();

        }
    }
}
