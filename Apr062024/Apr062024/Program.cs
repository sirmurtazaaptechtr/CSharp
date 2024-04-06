using System;


namespace Apr062024
{
    class Student
    {
        int _id;
        string _name;
        public string email;

        public void set_id (int ID)
        {
            this._id = ID;
        }
        public void set_name(string Name)
        {
            this._name = Name;
        }
        public int get_id()
        {
            return this._id;
        }
        public string getName()
        {
            return this._name;
        }

    }
    internal class Program
    {
        static void Main()
        {
            Student s1 = new Student();
            s1.set_id (1);
            s1.set_name("Ali Raza");
            s1.email = "ali@raza.com";

            Console.WriteLine($"ID : {s1.get_id()}\nName : {s1.getName()}\nEmail : {s1.email}");
        }
    }
}
