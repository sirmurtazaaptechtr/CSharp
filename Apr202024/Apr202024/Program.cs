using System;
using System.Text.RegularExpressions;

namespace Apr202024
{
    class Student
    {
        private int _id;
        private string _name;
        public float ObtMarks;
        private static float _maxmarks = 75;
        private static string _nameRegExPattern = @"^[a-zA-Z-' ]*$";

        public void SetId (int ID)
        {
            if(ID <= 0)
            {
                throw new Exception("Student ID should be greater than zero");
            }
            else
            {
                this._id = ID;
            }
        }
        public int GetId()
        {
            return this._id;
        }
        public void SetName(string Name)
        {
            Regex reName = new Regex(_nameRegExPattern);            

            if (string.IsNullOrEmpty(Name))
            {
                this._name = "No Name";
            }
            else if(!reName.IsMatch(Name))
            {
                this._name = "No Name";
            }
            else 
            {
                this._name = Name;                 
            }
        }
        public string GetName() 
        {
            if (string.IsNullOrEmpty(this._name))
            {
                return "No Name";
            }
            else
            {
                return this._name;
            }
        }

        public void Print ()
        {
            Console.WriteLine($"ID : {GetId()}\nName : {GetName()}\nPercentage : {this.ObtMarks / _maxmarks*100}%\n");
        }
    }
    internal class Program
    {
        static void Main()
        {
            Student s1 = new Student();
            s1.SetId(1);
            s1.SetName("Anshara Rizwan");            
            s1.ObtMarks = 253f;

            s1.Print();            
        }
    }
}
