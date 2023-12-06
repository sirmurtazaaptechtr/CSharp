using System;
using System.Text.RegularExpressions;
namespace Dec062023
{
    class Student
    {
        public string Pattern { get; } = @"^[a-zA-Z-' ]*$";
        private string _name;
        private int _age;
        public float MaxMarks { get; } = 75.0f;
        private float _obtmarks;
        public string Description{set;get;}

        public string Name 
        {
            set 
            {
                Regex re = new Regex(Pattern);
                if (re.IsMatch(value))
                {
                    this._name = value;
                }
                else
                {
                    this._name = "Invalid Name!";
                }
            }
            get 
            {
                if(string.IsNullOrEmpty(this._name))
                {
                    return "No Name";
                }
                else
                {
                    return this._name;
                }
            }
        }

        //public void SetName (string Name)
        //{
        //    Regex re = new Regex(this._pattern);
        //    if(re.IsMatch(Name))
        //    {
        //        this._name = Name;
        //    }
        //    else
        //    {
        //        this._name = "Invalid Name";
        //    }            
        //}
        //public string GetName ()
        //{
        //    if(string.IsNullOrEmpty(this._name))
        //    {
        //        return "No Name";
        //    }
        //    else
        //    {
        //        return this._name;
        //    }
        //}
        public int Age
        {
            set
            {
                if(value < 0)
                {
                    this._age = 0;
                }
                else
                {
                    this._age = value;
                }
            }
            get
            {
                return this._age;
            }
        }
        //public void SetAge (int Age)
        //{
        //    if(Age < 0) 
        //    {
        //        this._age = 0;
        //    }
        //    else
        //    {
        //        this._age = Age;
        //    }
        //}
        //public int GetAge ()
        //{
        //    return this._age;
        //}
        
        //public float GetMaxMarks ()
        //{
        //    return this._maxmarks;
        //}

        public float ObtMarks 
        {
            set
            {
                if(value < 0 || value >MaxMarks) 
                {
                    this._obtmarks = 0;
                }
                else
                {
                    this._obtmarks = value;
                }
            }
            get
            {
                return this._obtmarks;
            }
        }
        //public void SetObtMarks (float ObtMarks)
        //{
        //    if(ObtMarks < 0 || ObtMarks > this._maxmarks) 
        //    {
        //        this._obtmarks = 0;
        //    }
        //    else
        //    {
        //        this._obtmarks = ObtMarks;
        //    }
        //}
        //public float GetObtMarks () 
        //{
        //    return this._obtmarks;
        //}

        public void Print ()
        {
            Console.WriteLine("Name : {0}\nAge : {1}\nMax Marks : {2}\nObt. Marks : {3}\n", Name, Age, MaxMarks, ObtMarks);
        }
    }
    internal class Program
    {
        static void Main()
        {
            Student std = new Student();
            std.Name = "Kinza Danish";
            std.Age = 20;
            std.ObtMarks = 74.5f;            
            std.Print();
        }
    }
}