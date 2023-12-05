using System;
using System.Text.RegularExpressions;
namespace Dec042023_2
{
    class Student
    {
        private string _pattern = @"^[a-zA-Z-' ]*$";
        private int _id;
        private string _name;
        private int _age;

        public void SetID (int id)
        {
            if(id <=  0)
            {
                Console.WriteLine("Invalid ID!");
                this._id = 0;
            }
            else
            {
                this._id = id;
            }
        }
        public int GetID ()
        {
            return this._id;
        }
        public void SetName (string name)
        {
            Regex re = new Regex(this._pattern);
            if (re.IsMatch (name))
            {
                this._name = name;
            }
            else
            {
                this._name = "Invalid Name!";
            }
        }
        public string GetName ()
        {
            if(String.IsNullOrEmpty(this._name))
            {
                this._name = "No Name";
                return this._name;
            }
            else
            { 
                return this._name; 
            }
        }
        public void SetAge(int age)
        {
            if (age <= 0)
            {
                Console.WriteLine("Invalid Age!");
                this._age = 0;
            }
            else
            {
                this._age = age;
            }
        }
        public int GetAge()
        {
            return this._age;
        }

        public void Print ()
        {
            Console.WriteLine("ID : {0}\nName : {1}\nAge : {2}", GetID(), GetName(), GetAge());
        }
    }
    internal class Program
    {
        static void Main()
        {
            Student student =  new Student();
            student.SetID (1);
            student.SetName("Yaseen Afridi");
            student.SetAge (19);
            student.Print ();            
        }
    }
}